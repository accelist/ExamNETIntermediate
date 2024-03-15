using ExamNETIntermediate.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        public HttpClient _httpClient { get; set; } = new HttpClient();
        public List<SongModel> Songs { get; set; } = new List<SongModel>();
        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();

        public Form1()
        {
            InitializeComponent();
            InitializeFieldValues();
            PopulateListBox();
            PopulateComboBox();
        }

        /// <summary>
        /// Sets input fields format and bounds.
        /// </summary>
        public void InitializeFieldValues()
        {
            dateTimePickerReleaseDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerReleaseDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            labelMessageBox.Text = string.Empty;

            numericUpDownSongLengthMinutes.Minimum = 0;
            numericUpDownSongLengthSeconds.Minimum = 0;
            numericUpDownSongLengthSeconds.Maximum = 59;

            dateTimePickerReleaseDate.MaxDate = DateTime.Now.AddDays(7);
        }

        /// <summary>
        /// Pulling song data to listbox
        /// </summary>
        public async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");

            var jsonContent = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);

            if (content != null)
            {
                Songs = content;
            }

            var dataSourceSongs = new BindingSource();
            foreach (var song in Songs)
            {
                dataSourceSongs.Add(song);
            }

            listBoxSongs.DataSource = dataSourceSongs;
            listBoxSongs.DisplayMember = "Title";

            ClearInput();
        }

        /// <summary>
        /// Pulling genre data to combobox
        /// </summary>
        public async void PopulateComboBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");

            var jsonContent = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<List<GenreModel>>(jsonContent);

            if (content != null)
            {
                Genres = content;
            }

            var dataSourceGenres = new BindingSource();
            foreach (var genre in Genres)
            {
                dataSourceGenres.Add(genre);
            }

            comboBoxGenre.DataSource = dataSourceGenres;
            comboBoxGenre.DisplayMember = "GenreName";

            ClearInput();
        }

        /// <summary>
        /// Allows refreshing the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        /// <summary>
        /// Putting selected song's info in the input fields. 
        /// When the selected song has invalid release date (further 7 days from now), the date field will be set to the maximum date allowed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxSongs.SelectedIndex < 0)
            {
                return;
            }

            var selectedIndex = listBoxSongs.SelectedIndex;
            var selectedSong = listBoxSongs.Items[selectedIndex] as SongModel;

            if (selectedSong != null)
            {

                textBoxSongTitle.Text = selectedSong.Title;
                textBoxSongArtist.Text = selectedSong.Artist;

                var genre = Genres.FirstOrDefault(Q => Q.GenreName == selectedSong.GenreName);
                comboBoxGenre.SelectedItem = genre;

                numericUpDownSongLengthMinutes.Value = selectedSong.Length / 60;
                numericUpDownSongLengthSeconds.Value = selectedSong.Length % 60;

                labelReleaseDateWarning.Text = string.Empty;

                try
                {
                    dateTimePickerReleaseDate.Value = selectedSong.ReleaseDate.DateTime;
                }
                catch
                {
                    dateTimePickerReleaseDate.Value = DateTime.UtcNow.AddDays(7);
                    labelReleaseDateWarning.Text = "The selected song has release date further than 7 days from now. It has been set to current UTC time.";
                }

                checkBoxSongAvailability.Checked = selectedSong.IsAvailable;

                buttonAdd.Enabled = false;
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

        /// <summary>
        /// Enables adding new song based on data entered in the input field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            var songTitle = textBoxSongTitle.Text;
            var songArtist = textBoxSongArtist.Text;
            var selectedGenre = comboBoxGenre.SelectedItem as GenreModel;
            var lengthMinutes = (int)numericUpDownSongLengthMinutes.Value;
            var lengthSeconds = (int)numericUpDownSongLengthSeconds.Value;
            var releaseDate = new DateTimeOffset(dateTimePickerReleaseDate.Value);
            var releaseDateUtc = releaseDate.UtcDateTime;

            if (string.IsNullOrEmpty(songTitle))
            {
                labelTitleWarning.Text = "Song title can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(songArtist))
            {
                labelArtistWarning.Text = "Artist name can't be empty";
                return;
            }

            if (selectedGenre == null)
            {
                labelGenreWarning.Text = "Please choose genre from the available options.";
                return;
            }

            if (lengthMinutes == 0 && lengthSeconds == 0)
            {
                labelLengthWarning.Text = "Song length can't be 0.";
                return;
            }

            var songModel = new SongInputModel()
            {
                Title = songTitle,
                Artist = songArtist,
                GenreId = selectedGenre.GenreId,
                Length = (lengthMinutes * 60) + lengthSeconds,
                ReleaseDate = releaseDateUtc,
                IsAvailable = checkBoxSongAvailability.Checked,
            };

            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString);

            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelMessageBox.Text = "Song added successfully.";
            }
            else
            {
                labelMessageBox.Text = "Failed to add song.";
            }

            PopulateListBox();
        }

        /// <summary>
        ///  Enables updating selected song based on data entered in the input fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxSongs.SelectedIndex;
            var selectedSong = listBoxSongs.Items[selectedIndex] as SongModel;
            var selectedGenre = comboBoxGenre.SelectedItem as GenreModel;
            var lengthMinutes = (int)numericUpDownSongLengthMinutes.Value;
            var lengthSeconds = (int)numericUpDownSongLengthSeconds.Value;
            var releaseDate = new DateTimeOffset(dateTimePickerReleaseDate.Value);
            var releaseDateUtc = releaseDate.UtcDateTime;

            var songTitle = textBoxSongTitle.Text;
            var songArtist = textBoxSongArtist.Text;

            if (selectedSong == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(songTitle))
            {
                labelTitleWarning.Text = "Song title can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(songArtist))
            {
                labelArtistWarning.Text = "Artist name can't be empty";
                return;
            }

            if (selectedGenre == null)
            {
                labelGenreWarning.Text = "Please choose genre from the available options.";
                return;
            }

            if (lengthMinutes == 0 && lengthSeconds == 0)
            {
                labelLengthWarning.Text = "Song length can't be 0.";
                return;
            }

            var songModel = new SongInputModel()
            {
                SongId = selectedSong.SongId,
                Title = songTitle,
                Artist = songArtist,
                GenreId = selectedGenre.GenreId,
                Length = (lengthMinutes * 60) + lengthSeconds,
                ReleaseDate = releaseDateUtc,
                IsAvailable = checkBoxSongAvailability.Checked
            };

            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString);

            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelMessageBox.Text = "Song data updated successfully";
            }
            else
            {
                labelMessageBox.Text = "Failed to update song data";
            }

            PopulateListBox();
        }

        /// <summary>
        /// enables deleting song selected on the listbox by clicking delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxSongs.SelectedIndex;
            var selectedSong = listBoxSongs.Items[selectedIndex] as SongModel;

            if (selectedSong == null)
            {
                return;
            }

            var response = await _httpClient.DeleteAsync("https://new-dev.accelist.com:10000/api/song/" + selectedSong.SongId);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelMessageBox.Text = "Song deleted successfully.";
            }
            else
            {
                labelMessageBox.Text = "Failed to delete song.";
            }

            PopulateListBox();
        }

        /// <summary>
        /// Allows searching through the listbox. The search results are updated on searchbox value change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var query = textBoxSearch.Text;

            if (string.IsNullOrEmpty(query))
            {
                PopulateListBox();
            }
            else
            {
                var results = Songs.Where(Q => Q.Title.ToLower().Contains(query) || Q.Artist.ToLower().Contains(query));

                var dataSourceFiltered = new BindingSource();
                foreach (var song in results)
                {
                    dataSourceFiltered.Add(song);
                }

                listBoxSongs.DataSource = dataSourceFiltered;
                listBoxSongs.DisplayMember = "Title";
            }
        }
        
        /// <summary>
        /// Resets the input fields
        /// </summary>
        public void ClearInput()
        {
            textBoxSongTitle.Text = string.Empty;
            textBoxSongArtist.Text = string.Empty;
            comboBoxGenre.SelectedItem = null;
            numericUpDownSongLengthMinutes.Value = 0;
            numericUpDownSongLengthSeconds.Value = 0;
            dateTimePickerReleaseDate.Value = DateTime.UtcNow;
            checkBoxSongAvailability.Checked = false;

            labelArtistWarning.Text = string.Empty;
            labelTitleWarning.Text = string.Empty;
            labelGenreWarning.Text = string.Empty;

            labelLengthWarning.Text = string.Empty;
            labelReleaseDateWarning.Text = string.Empty;

            listBoxSongs.ClearSelected();

            buttonAdd.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }
        
        /// <summary>
        /// Allow deselecting item on listbox by clicking empty space on form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
    }
}
