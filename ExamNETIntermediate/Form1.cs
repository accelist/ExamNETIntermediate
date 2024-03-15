using ExamNETIntermediate.Models;
using Newtonsoft;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        public List<SongModel> Menus { get; set; } = new List<SongModel>();
        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();
        public HttpClient _httpClient { get; set; } = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            PopulateListBox();
            PopulateComboBox();
        }

        public void ClearForm()
        {
            textBoxTitle.Text = string.Empty;
            textBoxArtist.Text = string.Empty;
            comboBoxGenre.SelectedItem = null;
            checkIsAvailable.Checked = false;
            numericUpDown1.Value = 0M;
            numericUpDown2.Value = 0M;
            dateTimeRelease.Value = DateTime.Now;
            listBoxMenu.SelectedIndex = -1;
            textBoxSearch.Text = string.Empty;
        }

        public async void PopulateComboBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");

            var jsonContent = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var genres = System.Text.Json.JsonSerializer.Deserialize<List<GenreModel>>(jsonContent, options);

            if (genres != null)
            {
                Genres = genres;
            }

            comboBoxGenre.Items.Clear();
            comboBoxGenre.Items.AddRange(Genres.ToArray());
            comboBoxGenre.DisplayMember = "GenreName";
        }

        public async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);

            if (content != null)
            {
                Menus = content;
            }

            listBoxMenu.Items.Clear();
            listBoxMenu.Items.AddRange(Menus.ToArray());
            listBoxMenu.DisplayMember = "Title";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            PopulateListBox();
            labelNotification.Text = "Data updated";
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedItem != null)
            {
                MessageBox.Show("Please unselect the current item before adding a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tittle = textBoxTitle.Text;
            var artist = textBoxArtist.Text;
            int minutes = (int)numericUpDown1.Value;
            int seconds = (int)numericUpDown2.Value;
            int totalSeconds = (minutes * 60) + seconds;
            var selectedGenre = comboBoxGenre.SelectedItem as GenreModel;
            DateTime selectedDate = dateTimeRelease.Value.ToUniversalTime();
            DateTime sevenDaysFromNow = DateTime.UtcNow.AddDays(7);

            if (string.IsNullOrEmpty(tittle))
            {
                MessageBox.Show("Title can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(artist))
            {
                MessageBox.Show("Artist can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedGenre == null)
            {
                MessageBox.Show("Genre can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
            {
                MessageBox.Show("Invalid input for minutes or seconds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(numericUpDown1.Text, out minutes) || !int.TryParse(numericUpDown2.Text, out seconds))
            {
                MessageBox.Show("Invalid input for minutes or seconds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkIsAvailable.Checked)
            {
                MessageBox.Show("Song must be available to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedDate > sevenDaysFromNow)
            {
                MessageBox.Show("Selected date can't be more than 7 days from today", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var menuModel = new SongModelInput
            {
                Title = tittle,
                Artist = artist,
                GenreId = selectedGenre.GenreId,
                Length = totalSeconds,
                IsAvailable = checkIsAvailable.Checked,
                ReleaseDate = dateTimeRelease.Value,
            };

            var jsonString = JsonConvert.SerializeObject(menuModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Success to Insert data";
                ClearForm();
            }
            else
            {
                labelNotification.Text = "Failed to Insert data";
            }
            PopulateListBox(); 
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBoxMenu.SelectedItem as SongModel;

            if (selectedItem == null)
            {
                return;
            }

            textBoxTitle.Text = selectedItem.Title;
            textBoxArtist.Text = selectedItem.Artist;
            checkIsAvailable.Checked = selectedItem.IsAvailable;

            var currentGenre = Genres.FirstOrDefault(Q => Q.GenreName == selectedItem.GenreName);

            comboBoxGenre.SelectedItem = currentGenre;

            int totalSeconds = selectedItem.Length;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            numericUpDown1.Value = minutes;
            numericUpDown2.Value = seconds;

            dateTimeRelease.Value = selectedItem.ReleaseDate.LocalDateTime;
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedItem == null)
            {
                MessageBox.Show("No item selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedMenu = listBoxMenu.SelectedItem as SongModel;

            if (selectedMenu == null)
            {
                labelNotification.Text = "Can't delete empty item";
                return;
            }

            var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{selectedMenu.SongId}");

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Success to deleting data";
                ClearForm();
            }
            else
            {
                labelNotification.Text = "Failed to deleting data";
            }
            PopulateListBox();
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedItem == null)
            {
                MessageBox.Show("Please select a song to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var title = textBoxTitle.Text;
            var artist = textBoxArtist.Text;
            int minutes = (int)numericUpDown1.Value;
            int seconds = (int)numericUpDown2.Value;
            int totalSeconds = (minutes * 60) + seconds;
            var selectedSong = listBoxMenu.SelectedItem as SongModel;
            var selectedGenre = comboBoxGenre.SelectedItem as GenreModel;
            DateTime selectedDate = dateTimeRelease.Value.ToUniversalTime();
            DateTime sevenDaysFromNow = DateTime.UtcNow.AddDays(7);

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(artist))
            {
                MessageBox.Show("Artist can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedGenre == null)
            {
                MessageBox.Show("Genre can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
            {
                MessageBox.Show("Invalid input for minutes or seconds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(numericUpDown1.Text, out minutes) || !int.TryParse(numericUpDown2.Text, out seconds))
            {
                MessageBox.Show("Invalid input for minutes or seconds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkIsAvailable.Checked)
            {
                MessageBox.Show("Song must be available to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedDate > sevenDaysFromNow)
            {
                MessageBox.Show("Selected date can't be more than 7 days from today", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updatedModel = new SongModelInput
            {
                SongId = selectedSong.SongId,
                Title = title,
                Artist = artist,
                GenreId = selectedGenre.GenreId,
                Length = totalSeconds,
                IsAvailable = checkIsAvailable.Checked,
                ReleaseDate = dateTimeRelease.Value,
            };

            var jsonString = JsonConvert.SerializeObject(updatedModel);
            var contentHttp = new StringContent(jsonString);
            contentHttp.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            Debug.WriteLine(contentHttp);

            var response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", contentHttp);

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Success to Updating data";
                ClearForm();
            }
            else
            {
                labelNotification.Text = "Failed to Updating data";
            }

            PopulateListBox();
        }

        private async void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var searchSongName = textBoxSearch.Text;

            var response = await _httpClient.GetAsync($"https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();

            var allSongs = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);

            var filteredSongs = allSongs.Where(song =>
                song.Title.Contains(searchSongName, StringComparison.OrdinalIgnoreCase) ||
                song.Artist.Contains(searchSongName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            listBoxMenu.Items.Clear();
            listBoxMenu.Items.AddRange(filteredSongs.ToArray());
            listBoxMenu.DisplayMember = "Title";
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}