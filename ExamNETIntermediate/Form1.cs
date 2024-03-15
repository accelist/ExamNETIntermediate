using ExamNETIntermediate.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Diagnostics;
using System.Text;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Genre> Genres { get; set; } = new List<Genre>();

        public HttpClient _httpClient = new HttpClient();


        public Form1()
        {
            InitializeComponent();
            PopulateListBox();
            PopulateGenreBox();
            currentDateTime.Text = DateTime.Now.ToString();
        }

        public async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            var jsonContent = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<List<Song>>(jsonContent);

            if (content != null)
            {
                Songs = content;
            }


            songListBox.Items.Clear();
            songListBox.Items.AddRange(Songs.ToArray());
            songListBox.DisplayMember = "Title";


        }

        public async void PopulateGenreBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<Genre>>(jsonContent);

            if (content != null)
            {
                Genres = content;
            }

            genreComboBox.Items.Clear();
            genreComboBox.Items.AddRange(Genres.ToArray());
            genreComboBox.DisplayMember = "GenreName";

        }

        private void RefreshButtonClicked(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        private async void DeleteButtonClicked(object sender, EventArgs e)
        {
            var selectedItemToDelete = songListBox.SelectedItem as Song;
            if (selectedItemToDelete != null)
            {
                var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{selectedItemToDelete.SongId}");
            }
            PopulateListBox();
        }

        private async void AddButtonClicked(object sender, EventArgs e)
        {

            var inputTitle = songTitleBox.Text;
            var inputArtist = artistBox.Text;
            var inputAvailable = isAvailableCheckBox.Checked;
            int songLength = ((int)minutesLength.Value * 60) + (int)secondsLength.Value;
            var currentDate = releaseDate.Value.ToUniversalTime();

            // validation

            if (string.IsNullOrEmpty(songTitleBox.Text))
            {
                notificationLabel.Text = "Song title can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(artistBox.Text))
            {
                notificationLabel.Text = "Artist name can't be empty";
                return;
            }

            if (genreComboBox.SelectedItem == null)
            {
                notificationLabel.Text = "Genre can't be empty";
                return;
            }

            if (secondsLength.Value == 0)
            {
                notificationLabel.Text = "Second duration can't be empty";
                return;
            }

            if (minutesLength.Value == 0)
            {
                notificationLabel.Text = "Song duration can't be empty";
                return;
            }


            if(currentDate > DateTime.Now.AddDays(7) || currentDate < DateTime.Now) 
            {
                notificationLabel.Text = "Date must not be more than 7 days from now or before this day";
                return;
            }

            if (!isAvailableCheckBox.Checked)
            {
                notificationLabel.Text = "Is available checkbox should be checked";
                return;
            }


            var SongModel = new SongUpload()
            {
                Title = inputTitle,
                Artist = inputArtist,
                GenreId = genreComboBox.SelectedIndex + 1,
                Length = songLength,
                ReleaseDate = currentDate,
                IsAvailable = inputAvailable,
            };
            var jsonString = JsonConvert.SerializeObject(SongModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                notificationLabel.Text = "Succesfully to Insert New Song";
            }
            else
            {
                notificationLabel.Text = "Failed to Insert New Song";
            }

            PopulateListBox();
            ClearForm();
        }

        private async void UpdateButtonClicked(object sender, EventArgs e)
        {
            var currentDate = releaseDate.Value;

            if (songListBox.SelectedItem != null)
            {



                if (string.IsNullOrEmpty(songTitleBox.Text))
                {
                    notificationLabel.Text = "Song title can't be empty";
                    return;
                }

                if (string.IsNullOrEmpty(artistBox.Text))
                {
                    notificationLabel.Text = "Artist name can't be empty";
                    return;
                }

                if (genreComboBox.SelectedItem == null)
                {
                    notificationLabel.Text = "Genre can't be empty";
                    return;
                }

                if (secondsLength.Value == 0)
                {
                    notificationLabel.Text = "Second duration can't be empty";
                    return;
                }

                if (minutesLength.Value == 0)
                {
                    notificationLabel.Text = "Song duration can't be empty";
                    return;
                }

                if(currentDate > DateTime.Now.AddDays(7) || currentDate < DateTime.Now) 
                {
                    notificationLabel.Text = "Date must not be more than 7 days from now or before this day";
                    return;
                }

                if (!isAvailableCheckBox.Checked)
                {
                    notificationLabel.Text = "Is available checkbox should be checked";
                    return;
                }

                Song selectedSong = (Song)songListBox.SelectedItem;
                string updatedSongTitle = songTitleBox.Text;
                string updatedArtistTitle = artistBox.Text;
                int updatedGenreId = genreComboBox.SelectedIndex + 1;
                int updatedDuration = (int)((minutesLength.Value * 60) + secondsLength.Value);
                bool updatedIsAvailable = isAvailableCheckBox.Checked;
                DateTime updatedReleaseDate = releaseDate.Value;

                SongUpload updatedSong = new SongUpload
                {
                    SongId = selectedSong.SongId,
                    Title = updatedSongTitle,
                    Artist = updatedArtistTitle,
                    GenreId = updatedGenreId,
                    Length = updatedDuration,
                    IsAvailable = updatedIsAvailable,
                    ReleaseDate = updatedReleaseDate,
                };

                var jsonSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()

                };

                string json = JsonConvert.SerializeObject(updatedSong, jsonSettings);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);

                if (response.IsSuccessStatusCode)
                {
                    notificationLabel.Text = "Song updated successfully.";
                    PopulateListBox();
                }
                else
                {
                    notificationLabel.Text = $"Failed to update Song.\n Error: ${json}";
                }
            }
            else
            {
                notificationLabel.Text = "Please select a Song to update.";
            }

        }

        private void SongListSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = songListBox.SelectedIndex;
            var selectedItem = songListBox.Items[selectedIndex] as Song;
            if (selectedItem != null)
            {
                var selectedGenre = Genres.FirstOrDefault(items => items.GenreName == selectedItem.GenreName);

                songTitleBox.Text = selectedItem.Title;
                artistBox.Text = selectedItem.Artist;
                isAvailableCheckBox.Checked = selectedItem.IsAvailable;
                minutesLength.Value = (int)selectedItem.Length / 60;
                secondsLength.Value = (int)selectedItem.Length % 60;
                genreComboBox.SelectedItem = selectedGenre;
                releaseDate.Value = selectedItem.ReleaseDate;
            }
        }

        private void SearchBoxTextChanged(object sender, EventArgs e)
        {
            if (Songs.Count != 0)
            {
                var query = searchBox.Text;
                query = query.Replace(" ", "");
                var result = Songs.Where(song => song.Title.ToLower().Contains(query.ToLower()) || song.Artist.ToLower().Contains(query.ToLower())).ToList();
                songListBox.DataSource = result;
                songListBox.DisplayMember = "Title";
            }
        }

        private void SearchBoxClicked(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search song or artist")
            {
                searchBox.Text = string.Empty;
                searchBox.ForeColor = Color.Black;
            }
        }

        public void ClearForm()
        {
            songTitleBox.Text = string.Empty;
            artistBox.Text = string.Empty;
            genreComboBox.SelectedItem = null;
            isAvailableCheckBox.Checked = false;
            minutesLength.Value = 0;
            secondsLength.Value = 0;
            releaseDate.Value = DateTime.UtcNow;
        }

    }
}
