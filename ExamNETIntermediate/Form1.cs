using ExamNETIntermediate.Models;
using Newtonsoft.Json;

namespace ExamNETIntermediate
{
    //TODO add labels for minutes and seconds. Might need additional columns to make it work
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
            //TODO search functionality (plan: on value change, empty=no filter)
        }

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
            comboBoxGenre.SelectedIndex = -1;
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongModel? selectedItem = listBoxSongs.SelectedItem as SongModel;
            if (selectedItem == null) { return; } //handle null case

            textBoxTitle.Text = selectedItem.Title;
            textBoxArtist.Text = selectedItem.Artist;
            comboBoxGenre.SelectedItem = genres.Where(Q => Q.GenreName == selectedItem.GenreName).FirstOrDefault();
            dateTimePickerReleaseDate.Value = selectedItem.ReleaseDate;
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
        private void numericUpDownLengthSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownLengthSeconds.Value >= 60) //handling seconds overflow into minutes
            {
                numericUpDownLengthSeconds.Value = 0;
                numericUpDownLengthMinutes.Value += 1;
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            GenreModel? inputGenre = comboBoxGenre.SelectedItem as GenreModel;

            //input form validation
            //case: empty|null
            if (string.IsNullOrEmpty(textBoxTitle.Text)
                || string.IsNullOrEmpty(textBoxArtist.Text)
                || inputGenre == null
                || (numericUpDownLengthMinutes.Value == 0 && numericUpDownLengthSeconds.Value == 0))
            {
                labelMessage.Text = "Fields must not be empty!";
                return;
            }
            //case: >7 days
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
            input.ReleaseDate = dateTimePickerReleaseDate.Value;
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

            //input form validation
            //case: empty|null
            if (string.IsNullOrEmpty(textBoxTitle.Text)
                || string.IsNullOrEmpty(textBoxArtist.Text)
                || inputGenre == null
                || (numericUpDownLengthMinutes.Value == 0 && numericUpDownLengthSeconds.Value == 0))
            {
                labelMessage.Text = "Fields must not be empty!";
                return;
            }
            //case: >7 days
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
            editItem.ReleaseDate = dateTimePickerReleaseDate.Value;
            editItem.IsAvailable = checkBoxAvailable.Checked;

            var jsonContent = JsonConvert.SerializeObject(editItem);
            var content = new StringContent(jsonContent);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await httpClient.PutAsync(baseUrl + "/song", content);
            //response.EnsureSuccessStatusCode();
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


        public void Deselect()
        {
            comboBoxGenre.SelectedIndex = -1;
            listBoxSongs.SelectedIndex = -1;
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
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
            var list = songs.Where(Q=>Q.Title.Contains(search)).ToList();
            listBoxSongs.Items.AddRange(list.Cast<object>().ToArray());
            listBoxSongs.DisplayMember = "title";
        }
    }
}
