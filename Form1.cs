using System;
using System.Text;
using System.Net.Http;
using ExamNETIntermediate.Models;
using Newtonsoft;
using Newtonsoft.Json;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        public List<SongModel> Songs { get; set; } = new List<SongModel>();
        public HttpClient _httpClient { get; set; } = new HttpClient();
        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();
        public Form1()
        {
            InitializeComponent();
            PopulateListBox();
            PopulateComboBoxGenre();
            buttonAdd.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            labelNotification.Text = string.Empty;
        }

        // this method is used to refresh the page so the listBox can be updated, and also clear the inputs
        public void RefreshPage()
        {
            PopulateListBox();
            PopulateComboBoxGenre();
            ClearInput();
        }

        // this method is used to clear the input
        public void ClearInput()
        {
            textBoxTitle.Text = string.Empty;
            textBoxArtist.Text = string.Empty;
            comboBoxGenre.SelectedItem = null;
            numericUpDownMin.Value = 0;
            numericUpDownSec.Value = 0;
            checkBoxAvailable.Checked = false;

            buttonAdd.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        // this method will populate listBoxSong, which is initially empty, with songs that we will get from the api
        public async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);

            if (content != null)
            {
                Songs = content;
            }

            listBoxSong.DataSource = Songs;
            listBoxSong.DisplayMember = "Title";
        }

        // this method will populate the comboBoxGenre input, which is initially empty, with genres that we will get from the api
        public async void PopulateComboBoxGenre()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<GenreModel>>(jsonContent);

            if (content != null)
            {
                Genres = content;
            }

            comboBoxGenre.DataSource = Genres;
            comboBoxGenre.DisplayMember = "GenreName";
        }

        // this is the method called when buttonRefresh is clicked, which will refresh the page
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        // this is the method called when buttonAdd is clicked, which will post a Song object to the song api
        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var songTitle = textBoxTitle.Text;
            var songArtist = textBoxArtist.Text;
            var selectedGenre = comboBoxGenre.SelectedItem as GenreModel;
            var minutes = numericUpDownMin.Value;
            var minToSec = minutes * 60;
            var seconds = numericUpDownSec.Value;
            var totalSeconds = minToSec + seconds;
            var date = new DateTimeOffset(dateTimePicker.Value);
            var releaseDate = date.UtcDateTime;
            var maxDate = DateTimeOffset.Now.AddDays(7);
                
            if (string.IsNullOrEmpty(songTitle))
            {
                labelNotification.Text = "Title cannot be empty!";
                return;
            }
            if (string.IsNullOrEmpty(songArtist))
            {
                labelNotification.Text = "Artist cannot be empty!";
                return;
            }
            if (seconds == 0 || minutes == 0)
            {
                labelNotification.Text = "There must be minutes and seconds!";
                return;
            }
            if (seconds < 0 || seconds > 59)
            {
                labelNotification.Text = "Seconds must be more than 0 and less than 59!";
                return;
            }
            if(releaseDate > maxDate)
            {
                labelNotification.Text = "Date cannot be more than 7 days than current date!";
                return;
            }
            if (checkBoxAvailable.Checked == false)
            {
                labelNotification.Text = "Song must be available!";
                return;
            }

            var songModel = new SongModel
            {

                Title = songTitle,
                Artist = songArtist,
                GenreId = selectedGenre.GenreId,
                Length = (int)totalSeconds,
                ReleaseDate = releaseDate,
                IsAvailable = checkBoxAvailable.Checked
            };

            var jsonString = JsonConvert.SerializeObject(songModel);
            //var content = new StringContent(jsonString, Encoding.UTF8, "application/json)
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Succesfully Inserted New Song";
            }
            else
            {
                labelNotification.Text = "Failed to Insert New Song";
            }
            RefreshPage();
        }

        // this is the method called when buttonUpdate is clicked, which will put a Song object to the song api to replace the selected Song
        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            var songTitle = textBoxTitle.Text;
            var songArtist = textBoxArtist.Text;
            var selectedGenre = comboBoxGenre.SelectedItem as GenreModel;
            var minutes = numericUpDownMin.Value;
            var minToSec = minutes * 60;
            var seconds = numericUpDownSec.Value;
            var totalSeconds = minToSec + seconds;
            var date = new DateTimeOffset(dateTimePicker.Value);
            var releaseDate = date.UtcDateTime;
            var maxDate = DateTimeOffset.Now.AddDays(7);

            var selectedIndex = listBoxSong.SelectedIndex;
            var song = listBoxSong.Items[selectedIndex] as SongModel;

            if (string.IsNullOrEmpty(songTitle))
            {
                labelNotification.Text = "Title cannot be empty!";
                return;
            }
            if (string.IsNullOrEmpty(songArtist))
            {
                labelNotification.Text = "Artist cannot be empty!";
                return;
            }
            if (seconds == 0 || minutes == 0)
            {
                labelNotification.Text = "There must be minutes and seconds!";
                return;
            }
            if (seconds < 0 || seconds > 59)
            {
                labelNotification.Text = "Seconds must be more than 0 and less than 59!";
                return;
            }
            if (releaseDate > maxDate)
            {
                labelNotification.Text = "Date cannot be more than 7 days than current date!";
                return;
            }
            if (checkBoxAvailable.Checked == false)
            {
                labelNotification.Text = "Song must be available!";
                return;
            }

            var songModel = new SongModel
            {
                SongId = song.SongId,
                Title = songTitle,
                Artist = songArtist,
                GenreId = selectedGenre.GenreId,
                Length = (int)totalSeconds,
                ReleaseDate = releaseDate,
                IsAvailable = checkBoxAvailable.Checked
            };

            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


            var response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Succesfully Updatedd Song";
            }
            else
            {
                labelNotification.Text = "Failed to Update Song";
            }
            RefreshPage();
        }

        // this is the method called when buttonDelete is clicked, which will delete a song from the api based on the song selected
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = this.listBoxSong.SelectedItem as SongModel;
            var selectedIndex = listBoxSong.SelectedIndex;
            var selectedSong = listBoxSong.Items[selectedIndex] as SongModel;

            if (selectedItem == null)
            {
                labelNotification.Text = "Cannot find selected item";
            }

            var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{selectedSong.SongId}");
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Succesfully Deleted Song";
            }
            else
            {
                labelNotification.Text = "Failed to Delete Song";
            }
            RefreshPage();
        }

        // this is the method called when a song in listBoxSong is selected, to display the information of the song in the input
        private void listBoxSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = listBoxSong.SelectedIndex;
            var selectedSong = listBoxSong.Items[selectedIndex] as SongModel;
            var dateTimeOffset = selectedSong.ReleaseDate;
            var dateTime = dateTimeOffset.LocalDateTime;

            if (selectedSong != null)
            {
                textBoxArtist.Text = selectedSong.Artist;
                textBoxTitle.Text = selectedSong.Title;
                var genreName = Genres.Where(x => x.GenreId == selectedSong.GenreId);
                comboBoxGenre.SelectedItem = genreName;
                checkBoxAvailable.Checked = selectedSong.IsAvailable;
                dateTimePicker.Value = dateTime;
            }

            buttonAdd.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
        }

        // this is the method called when buttonSearch is clicked, which will search through the Songs list which is based off the songs in the api, and display the results in listBoxSong
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchedSong = textBoxSearch.Text;

            var response = _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song").GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            var jsonContent = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);

            if (content != null)
            {
                Songs = content;
            }

            if (!string.IsNullOrEmpty(searchedSong))
            {
                var filterSong = (from song in Songs
                                  where song.Title.Contains(searchedSong) || song.Artist.Contains(searchedSong)
                                  select song).ToList();

                listBoxSong.DataSource = filterSong;
                listBoxSong.DisplayMember = "SongName";
            }


        }
    }
}
