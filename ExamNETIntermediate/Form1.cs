using ExamNETIntermediate.Models;
using Newtonsoft.Json;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        List<SongModel> songs = new List<SongModel>();
        List<GenreModel> genres = new List<GenreModel>();
        HttpClient httpClient = new HttpClient();
        string baseUrl = "https://new-dev.accelist.com:10000/api";
        public Form1()
        {
            InitializeComponent();
            GetDataListBox();
            GetDataGenre();
            Deselect();
        }
        /// <summary>
        /// Uses http GET request to the API to get song list. Listbox displays each song's title. Clears and repopulates listbox and internal List every call.
        /// </summary>
        /// <remarks>
        /// Does not use .DataSource to populate because it autoselects listbox and ruins other functions.
        /// </remarks>
        public async void GetDataListBox()
        {
            var response = await httpClient.GetAsync(baseUrl + "/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);
            if (content != null) songs = content;

            listBoxSongs.Items.Clear();
            var contentObject = songs.Cast<Object>().ToArray();
            listBoxSongs.Items.AddRange(contentObject);
            listBoxSongs.DisplayMember = "title";
        }
        /// <summary>
        /// Gets genre list from API. Since genre can only be changed by host, this is a one time call in initialization. Genre populates combobox, displays genre name.
        /// </summary>
        public async void GetDataGenre()
        {
            var response = await httpClient.GetAsync(baseUrl + "/genre");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<GenreModel>>(jsonContent);
            if (content != null) genres = content;

            var contentObject = genres.Cast<Object>().ToArray();
            comboBoxGenre.Items.AddRange(contentObject);
            comboBoxGenre.DisplayMember = "genreName";
        }
        /// <summary>
        /// Method to reset the form. Sets fields values to null/zero/empty. Also deselects lisbox and combobox.
        /// </summary>
        public void ClearForm()
        {
            textBoxTitle.Text = "";
            textBoxArtist.Text = "";
            comboBoxGenre.SelectedItem = null;
            numericUpDownLengthMinutes.Value = 0;
            numericUpDownLengthSeconds.Value = 0;
            checkBoxAvailable.Checked = false;

            labelMessage.Text = "Waiting...";
            Deselect();
        }
        /// <summary>
        /// Deselects listbox and combobox. When listbox is not selecting an item, user can only use add button for new songs.
        /// </summary>
        public void Deselect()
        {
            comboBoxGenre.SelectedIndex = -1;
            listBoxSongs.SelectedIndex = -1;
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
        }
        /// <summary>
        /// Method called when user selects a listbox item. This populates all the form's fields with the selected item's data. User can then edit or delete the item from list, but can not add new items until deselect happens. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongModel? selectedItem = listBoxSongs.SelectedItem as SongModel;
            if (selectedItem == null) { return; } //handle null case

            textBoxTitle.Text = selectedItem.Title;
            textBoxArtist.Text = selectedItem.Artist;
            comboBoxGenre.SelectedItem = genres.Where(Q => Q.GenreName == selectedItem.GenreName).FirstOrDefault();
            DateTime utcTime = selectedItem.ReleaseDate;
            dateTimePickerReleaseDate.Value = utcTime.ToLocalTime();
            int minutes = selectedItem.Length / 60;
            int seconds = selectedItem.Length % 60;
            numericUpDownLengthMinutes.Value = minutes;
            numericUpDownLengthSeconds.Value = seconds;
            checkBoxAvailable.Checked = selectedItem.IsAvailable;

            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
            buttonAdd.Enabled = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetDataListBox();
        }

        /// <summary>
        /// Method that processes form inputs and sends the new song to the API. Validation includes no fields are empty or zero, and the song's release date must be at most 7 days from now. Success/fail is displayed in the message label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            GenreModel? inputGenre = comboBoxGenre.SelectedItem as GenreModel;

            //input form validation
            if (string.IsNullOrEmpty(textBoxTitle.Text)
                || string.IsNullOrEmpty(textBoxArtist.Text)
                || inputGenre == null
                || (numericUpDownLengthMinutes.Value == 0 && numericUpDownLengthSeconds.Value == 0))
            {
                labelMessage.Text = "Fields must not be empty!";
                return;
            }
            DateTime currentTime = DateTime.UtcNow;
            TimeSpan timeDiff = dateTimePickerReleaseDate.Value - currentTime;
            if (timeDiff.Days > 7)
            {
                labelMessage.Text = "Release date can not be more than 7 days from now!";
                return;
            }

            SongInputModel input = new SongInputModel();
            input.Title = textBoxTitle.Text;
            input.Artist = textBoxArtist.Text;
            input.GenreId = inputGenre.GenreId;
            DateTime localTime = dateTimePickerReleaseDate.Value;
            input.ReleaseDate = localTime.ToUniversalTime();
            input.Length = (int)numericUpDownLengthMinutes.Value * 60 + (int)numericUpDownLengthSeconds.Value;
            input.IsAvailable = checkBoxAvailable.Checked;

            var jsonContent = JsonConvert.SerializeObject(input);
            var content = new StringContent(jsonContent);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            if (content == null) { return; }

            var response = await httpClient.PostAsync(baseUrl + "/song", content);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                GetDataListBox();
                ClearForm();
                labelMessage.Text = "Song upload successful!";
            }
            else
            {
                labelMessage.Text = "Song upload failed!";
            }
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            SongModel? selectedItem = listBoxSongs.SelectedItem as SongModel;
            if (selectedItem == null)
            {
                labelMessage.Text = "selected item does not exist";
                return;
            }
            GenreModel? inputGenre = comboBoxGenre.SelectedItem as GenreModel;
            SongEditModel editItem = new SongEditModel();

            if (string.IsNullOrEmpty(textBoxTitle.Text)
                || string.IsNullOrEmpty(textBoxArtist.Text)
                || inputGenre == null
                || (numericUpDownLengthMinutes.Value == 0 && numericUpDownLengthSeconds.Value == 0))
            {
                labelMessage.Text = "Fields must not be empty!";
                return;
            }
            DateTime currentTime = DateTime.UtcNow;
            TimeSpan timeDiff = dateTimePickerReleaseDate.Value - currentTime;
            if (timeDiff.Days > 7)
            {
                labelMessage.Text = "Release date can not be more than 7 days from now!";
                return;
            }

            editItem.SongId = selectedItem.SongId;
            editItem.Title = textBoxTitle.Text;
            editItem.Artist = textBoxArtist.Text;
            editItem.GenreId = inputGenre.GenreId;
            editItem.Length = (int)numericUpDownLengthMinutes.Value * 60 + (int)numericUpDownLengthSeconds.Value;
            DateTime localTime = dateTimePickerReleaseDate.Value;
            editItem.ReleaseDate = localTime.ToUniversalTime();
            editItem.IsAvailable = checkBoxAvailable.Checked;

            var jsonContent = JsonConvert.SerializeObject(editItem);
            var content = new StringContent(jsonContent);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await httpClient.PutAsync(baseUrl + "/song", content);
            if (response.IsSuccessStatusCode)
            {
                GetDataListBox();
                ClearForm();
                labelMessage.Text = "Edit success!";
            }
            else
            {
                labelMessage.Text = "Edit failed!";
            }

        }
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            SongModel? selectedItem = listBoxSongs.SelectedItem as SongModel;
            if (selectedItem == null)
            {
                labelMessage.Text = "Item does not exist!";
                return;
            }
            int songId = selectedItem.SongId;

            var response = await httpClient.DeleteAsync(baseUrl + $"/song/{songId}");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                GetDataListBox();
                ClearForm();
                labelMessage.Text = $"Delete success! (ID: {songId})";
            }
            else
            {
                labelMessage.Text = "Delete failed!";
            }
        }

        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxSongs.Items.Clear();
            var search = textBoxSearch.Text;
            if (string.IsNullOrEmpty(search))
            {
                listBoxSongs.Items.AddRange(songs.Cast<object>().ToArray());
                listBoxSongs.DisplayMember = "title";

                return;
            }
            var list = songs.Where(Q => Q.Title.Contains(search)).ToList();
            listBoxSongs.Items.AddRange(list.Cast<object>().ToArray());
            listBoxSongs.DisplayMember = "title";
        }

        private void numericUpDownLengthSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownLengthSeconds.Value >= 60) 
            {
                numericUpDownLengthSeconds.Value = 0;
                numericUpDownLengthMinutes.Value += 1;
            }
        }


    }
}
