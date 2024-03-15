using ExamNETIntermediate.Models;
using Newtonsoft.Json;
using Newtonsoft;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        public List<SongModel> Songs { get; set; } = new List<SongModel>();
        public HttpClient RefHttpClient { get; set; } = new HttpClient();
        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();
        public Form1()
        {
            InitializeComponent();
            labelNotif.ForeColor = Color.Red;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            PopulateSongList();
            PopulateComboBox();
        }

        public async void PopulateSongList()
        {
            var response = await RefHttpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();

            var jsonContent = await response.Content.ReadAsStringAsync();

            var songs = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);

            if (songs != null)
            {
                Songs = songs;
            }

            songListBox.Items.Clear();
            songListBox.Items.AddRange(Songs.ToArray());
            songListBox.DisplayMember = "Title";

            songListBox.SelectedIndexChanged += SongListBox_SelectedIndexChanged;
        }

        public async void PopulateComboBox()
        {
            var response = await RefHttpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");

            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<List<GenreModel>>(jsonContent);

            if (content != null)
            {
                Genres = content;
            }
            genreComboBox.DataSource = Genres;
            genreComboBox.DisplayMember = "GenreName";
        }

        private void SongListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var selectedSong = songListBox.SelectedItem as SongModel;
            var selectedGenre = genreComboBox.SelectedItem as GenreModel;
            DateTime? releaseDate = releaseDatePicker.Value;
            DateTime utcReleaseDate = ((DateTime)releaseDate).ToUniversalTime();
            if (selectedSong != null)
            {
                string lengthAsString = selectedSong.Length.ToString();
                string releaseDateText = utcReleaseDate.ToString("g");
                titleTextBox.Text = selectedSong.Title;
                artistTextBox.Text = selectedSong.Artist;
                genreComboBox.SelectedItem = Genres.FirstOrDefault(g => g.GenreName == selectedSong.GenreName);

                //MinuteNum.Maximum = 1440;
                //MinuteNum.Value = selectedSong.Length;

                SecondNum.Maximum = 86400;
                SecondNum.Value = selectedSong.Length;

                lengthSeconds.Text = $"Duration is {lengthAsString} seconds";
                releaseDatePicker.Value = DateTime.Parse(selectedSong.ReleaseDate);
                releaseDateAfter.Text = releaseDateText;
                availableCheckBox.Checked = selectedSong.IsAvailable;

            }
        }

        public void ClearForm()
        {
            titleTextBox.Text = string.Empty;
            artistTextBox.Text = string.Empty;
            genreComboBox.SelectedItem = null;
            MinuteNum.Value = 0;
            SecondNum.Value = 0;
            availableCheckBox.Checked = false;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            songListBox.Items.Clear();
            PopulateSongList();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            var title = titleTextBox.Text;
            var artist = artistTextBox.Text;
            DateTime? releaseDate = releaseDatePicker.Value;

            var idSent = 0;
            var selGenre = genreComboBox.SelectedItem as GenreModel;
            var selGenreId = Genres.Where(Q => Q.GenreName == selGenre?.GenreName).Select(R => R.GenreId);

            foreach (var item in selGenreId)
            {
                idSent = item;
            }
            // Tanggal rilis tidak boleh kosong dan maksimal 7 hari ke depan
            if (releaseDate == null || releaseDate > DateTime.Now.AddDays(7))
            {
                labelNotif.Text = "Release date can't be empty and must be within 7 days from now";
                return;
            }
            DateTime utcReleaseDate = DateTime.SpecifyKind((DateTime)releaseDate, DateTimeKind.Utc);

            if (string.IsNullOrEmpty(title))
            {
                labelNotif.Text = "Song Title can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(artist))
            {
                labelNotif.Text = "Song Artist can't be empty";
                return;
            }
            if (selGenre == null)
            {
                labelNotif.Text = "Genre can't be empty";
                return;
            }

            if (MinuteNum.Value == 0 || SecondNum.Value == 0)
            {
                labelNotif.Text = "Minutes and seconds can't be empty";
                return;
            }

            // Check if seconds value is between 0 and 59
            if (SecondNum.Value < 0 || SecondNum.Value > 59)
            {
                labelNotif.Text = "Seconds must be between 0 and 59";
                return;
            }

            var minutes = MinuteNum.Value;
            var seconds = SecondNum.Value;
            int lengthInSeconds = Convert.ToInt32(Math.Floor(minutes * 60 + seconds));


            var songModel = new InputSongModel
            {
                SongId = Songs.Count + 1,
                Title = title,
                Artist = artist,
                GenreId = idSent,
                Length = lengthInSeconds,
                ReleaseDate = utcReleaseDate.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                IsAvailable = availableCheckBox.Checked
            };

            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await RefHttpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelNotif.ForeColor = Color.Green;
                labelNotif.Text = "Succesfully to Insert New Menu";
            }
            else
            {
                labelNotif.Text = "Failed to Insert New Menu";
            }
            ClearForm();
            PopulateSongList();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            //Searches the selected item
            var selListBox = songListBox.SelectedItem as SongModel;


            var idSent = 0;
            var selGenre = genreComboBox.SelectedItem as GenreModel;
            var selGenreId = Genres.Where(Q => Q.GenreName == selGenre?.GenreName).Select(R => R.GenreId);

            //Searches every item in the genre that is the same as the selected genre
            foreach (var item in selGenreId)
            {
                idSent = item;
            }
            if (selListBox == null)
            {
                labelNotif.Text = "No songs selected";
                return;
            }

            var minutes = MinuteNum.Value;
            var seconds = SecondNum.Value;
            //Converts the value we get from the input into seconds
            int lengthInSeconds = Convert.ToInt32(Math.Floor(minutes * 60 + seconds));

            var menuModel = new InputSongModel
            {
                SongId = Songs.Count + 1,
                Title = titleTextBox.Text,
                Artist = artistTextBox.Text,
                GenreId = idSent,
                Length = lengthInSeconds,
                ReleaseDate = releaseDatePicker.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                IsAvailable = availableCheckBox.Checked
            };


            var jsonString = JsonConvert.SerializeObject(menuModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


            var response = await RefHttpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelNotif.ForeColor = Color.Green;
                labelNotif.Text = "Successfully Updated Menu";
                PopulateSongList();
            }
            else
            {
                labelNotif.Text = "Failed to Update Menu";
            }
            ClearForm();
            PopulateSongList();
        }
        
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //List baru
            List<SongModel> list = new List<SongModel>();
            var searchText = searchTextBox.Text;
            if (searchText != "")
            {
                list = Songs.Where(Q => Q.Title.Contains(searchText) || Q.Artist.Contains(searchText)).ToList();

                songListBox.DataSource = list;
                songListBox.DisplayMember = "Title";
            }
            else
            {
                //Populates again
                PopulateSongList();
            }
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Searches the index of the selected song
            var selectedSongindex = songListBox.SelectedIndex;
            var selectedSong = songListBox.Items[selectedSongindex] as SongModel;

            if (selectedSong == null)
            {
                labelNotif.Text = "Can't delete empty item";
                return;
            }
            //Response waiting
            var response = await RefHttpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{selectedSong.SongId}");

            if (response.IsSuccessStatusCode)
            {
                labelNotif.ForeColor = Color.Green;
                labelNotif.Text = "Successully deleted song";
            }
            else
            {
                labelNotif.Text = "Failed to delete song";
            }
            //Populates and clears the input form
            PopulateSongList();
            ClearForm();
        }
    }
}
