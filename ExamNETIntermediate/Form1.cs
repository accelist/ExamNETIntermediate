using ExamNETIntermediate.Models;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        public List<SongModel> SongModels { get; set; } = new List<SongModel>();
        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();
        public HttpClient _httpClient { get; set; } = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            PopulateListBox();
            PopulateComboBox();
        }

        // Simple Methods to set length in minute and second
        public int LengthConvertMinute(int length)
        {
            int minute = length / 60;
            return minute;
        }

        public int LengthConvertSecond(int length)
        {
            int second = length & 60;
            return second;
        }

        // Method to convert input music length to actual length in seconds
        public int LengthInSecond(int minute, int second)
        {
            return (minute * 60) + second;
        }

        // Method to generate List Box value
        public async Task PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);
            if (content != null) /// Jika Objek sudah di deserialisasi, dan object tidak null, maka SongModels akan diisi oleh object
            {
                SongModels = content;
            }

            listBoxLagu.Items.Clear();
            listBoxLagu.Items.AddRange(SongModels.ToArray());

            listBoxLagu.DisplayMember = "Title";
        }

        // Method to generate combo box value
        public async void PopulateComboBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");
            response.EnsureSuccessStatusCode();

            var jsonContent = await response.Content.ReadAsStringAsync();
            var genres = JsonConvert.DeserializeObject<List<GenreModel>>(jsonContent);

            if (genres != null)
            {
                Genres = genres;
            }
            comboBoxGenre.Items.Clear();
            comboBoxGenre.Items.AddRange(Genres.ToArray());
            comboBoxGenre.DisplayMember = "GenreName";
        }

        // Method to select the current index option and then auto fill the properties in tableLayout
        private void ListBoxLagu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBoxLagu.SelectedItem as SongModel;
            if (selectedItem == null) return;
            textBoxTitle.Text = selectedItem.Title;
            textBoxArtist.Text = selectedItem.Artist;
            checkBoxIsAvailable.Checked = selectedItem.IsAvailable;
            int length = selectedItem.Length;
            int minute = LengthConvertMinute(length);
            int second = LengthConvertSecond(length);
            numericUpDownMinute.Value = minute;
            numericUpDownSecond.Value = second;

            var currentGenre = Genres.Where(R => R.GenreName == selectedItem.GenreName).FirstOrDefault();

            comboBoxGenre.SelectedItem = currentGenre;
        }

        /// Method to add new song data into the list
        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            var songName = textBoxTitle.Text;
            var songArtist = textBoxArtist.Text;
            var selectedGenre = comboBoxGenre.SelectedItem as GenreModel;
            int selectedMinute = (int)numericUpDownMinute.Value;
            int selectedSecond = (int)numericUpDownSecond.Value;
            var asSecond = LengthInSecond(selectedMinute, selectedSecond);


            // Validation logic
            if (string.IsNullOrEmpty(songName) || string.IsNullOrEmpty(songArtist))
            {
                textBoxMessage.Text = "Song or artist name can't be empty!";
                return;
            }
            else if (selectedGenre == null)
            {
                textBoxMessage.Text = "Genre can't be empty";
                return;
            }
            else if (selectedMinute <= 0 || selectedMinute >= 59)
            {
                textBoxMessage.Text = "Minute must be between 1 and 59";
                return;
            }
            else if (selectedSecond <= 0 && selectedMinute == 0 || selectedSecond >= 59)
            {
                textBoxMessage.Text = "Second must be between 0 and 59";
                return;
            }

            var songModel = new SongModelInput()
            {
                Title = songName,
                Artist = songArtist,
                GenreId = selectedGenre.GenreId,
                IsAvailable = checkBoxIsAvailable.Checked,
                Length = asSecond,
                ReleaseDate = DateTime.UtcNow
            };

            var jsonString = JsonConvert.SerializeObject(songModel);

            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                textBoxMessage.Text = "Added new Song";
            }
            else
            {
                textBoxMessage.Text = "Failed to add new Song";
            }
            await PopulateListBox();
        }

        private async void ButtonRefresh_Click(object sender, EventArgs e)
        {
            await PopulateListBox();
        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            var selectedSongIndex = listBoxLagu.SelectedIndex;
            var selectedSong = listBoxLagu.Items[selectedSongIndex] as SongModel;

            if (selectedSong == null)
            {
                textBoxMessage.Text = "Can't delete";
                return;
            }
            var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{selectedSong.SongId}");

            if (response.IsSuccessStatusCode)
            {
                textBoxMessage.Text = "Success";
            }
            else
            {
                textBoxMessage.Text = "failed";
            }

            await PopulateListBox();
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxLagu.SelectedItem != null)
            {
                var selectedSong = listBoxLagu.SelectedItem as SongModel;
                var songName = textBoxTitle.Text;
                var songArtist = textBoxArtist.Text;
                var selectedGenre = comboBoxGenre.SelectedItem as GenreModel;
                int selectedMinute = (int)numericUpDownMinute.Value;
                int selectedSecond = (int)numericUpDownSecond.Value;
                var asSecond = LengthInSecond(selectedMinute, selectedSecond);

                if (string.IsNullOrEmpty(songName))
                {
                    textBoxMessage.Text = "Song Name can't be empty";
                    return;
                }

                if (string.IsNullOrEmpty(songArtist))
                {
                    textBoxMessage.Text = "Song Artist can't be empty";
                    return;
                }

                var updateModel = new SongModelInput
                {
                    SongId = selectedSong.SongId,
                    Title = songName,
                    IsAvailable = checkBoxIsAvailable.Checked,
                    Artist = songArtist,
                    Length = asSecond,
                    ReleaseDate = DateTime.UtcNow,
                    GenreId = selectedGenre.GenreId
                };
                var jsonString = JsonConvert.SerializeObject(updateModel);
                var content = new StringContent(jsonString);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    textBoxMessage.Text = "Song updated";
                }
                else
                {
                    textBoxMessage.Text = "Failed to update Song";
                }

            }
            await PopulateListBox();
        }

        private void ButtonAddInit_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void ClearForm()
        {
            listBoxLagu.SelectedItem = null;
            textBoxTitle.Text = string.Empty;
            textBoxArtist.Text = string.Empty;
            comboBoxGenre.SelectedItem = null;
            checkBoxIsAvailable.Checked = false;
            numericUpDownMinute.Value = 0;
            numericUpDownSecond.Value = 0;
            dateTimePickerRelease.Value = DateTime.UtcNow;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var textToSearch = textBoxSearch.Text.ToLower();
            var filteredText = SongModels.Where(M => M.Title.ToLower().Contains(textToSearch)).ToList();
            listBoxLagu.Items.Clear();
            listBoxLagu.Items.AddRange(filteredText.ToArray());
        }
    }
}
