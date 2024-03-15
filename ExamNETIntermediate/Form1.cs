using ExamNETIntermediate.Models;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        public const string ApiBaseUrl = "https://new-dev.accelist.com:10000";
        private bool isValid;

        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public HttpClient HttpClient { get; set; } = new HttpClient();


        public Form1()
        {
            InitializeComponent();
            PopulateGenreComboBox();
            //LoadGenresAndSongs();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadGenresAndSongs();
                if (Songs != null && Songs.Any())
                {
                    var uniqueGenres = Songs.Select(Song => Song.GenreName).Distinct();
                    foreach (var genre in uniqueGenres)
                    {
                        comboBoxGenre.Items.Add(genre);
                    }
                }
                else
                {
                    MessageBox.Show("No songs loaded. Please check your internet connection or try again later.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error onccurred : {ex.Message}");
            }
        }

        private async Task LoadGenresAndSongs()
        {
            var genreResponse = await HttpClient.GetAsync($"{ApiBaseUrl}/api/genre");
            var songResponse = await HttpClient.GetAsync($"{ApiBaseUrl}/api/song");

            if (genreResponse.IsSuccessStatusCode && songResponse.IsSuccessStatusCode)
            {
                var GenreJson = await genreResponse.Content.ReadAsStringAsync();
                var SongJson = await songResponse.Content.ReadAsStringAsync();

                var Genres = JsonConvert.DeserializeObject<List<Genre>>(GenreJson);
                var Songs = JsonConvert.DeserializeObject<List<Song>>(SongJson);

                RefreshListBox();
            }
            else
            {
                MessageBox.Show("Failed to fetch data from the API.");
            }
        }
        private void PopulateGenreComboBox()
        {
            comboBoxGenre.Items.Clear();
            if (Genres != null && Genres.Any())
            {
                foreach (var genre in Genres)
                {
                    comboBoxGenre.Items.Add(new KeyValuePair<int, string>(genre.genreId, genre.genreName));
                }
            }
            else
            {
                MessageBox.Show("No songs loaded. Please check your internet connection or try again later.");
            }
            
        }

        private void RefreshListBox()
        {
            listBoxSongs.DataSource = null;
            listBoxSongs.DisplayMember = "Title";
            listBoxSongs.DataSource = Songs.Select(Song => Song.Title).ToList();
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex != -1)
            {
                var selectedSong = Songs[listBoxSongs.SelectedIndex];
                textBoxTitle.Text = selectedSong.Title;
                textBoxArtist.Text = selectedSong.Artist;
                comboBoxGenre.SelectedItem = selectedSong.GenreName;
                checkBoxIsAvailable.Checked = selectedSong.IsAvailable;

            }
            else
            {
                ClearInputs();
            }
        }
        private void ClearInputs()
        {
            textBoxTitle.Clear();
            textBoxArtist.Clear();
            comboBoxGenre.SelectedItem = null;
            checkBoxIsAvailable.Checked = false;
        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            
            ValidateInputs();
            if (isValid)
            {
                var newSong = new Song
                {
                    Title = textBoxTitle.Text,
                    Artist = textBoxArtist.Text,
                    GenreName = comboBoxGenre.Text,
                    IsAvailable = checkBoxIsAvailable.Checked,
                };
                if (string.IsNullOrWhiteSpace(newSong.GenreName))
                {
                    MessageBox.Show("Please select a genre.");
                    return;
                }
                var json = JsonConvert.SerializeObject(newSong);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await HttpClient.PostAsync($"{ApiBaseUrl}/api/song", content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Song added successfully");
                        await LoadGenresAndSongs();
                        RefreshListBox();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add song.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

            }
        }
        public void ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("Title cannot be empty.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxArtist.Text))
            {
                MessageBox.Show("Artist cannot be empty.");
                isValid = false;
            }

            if (comboBoxGenre.SelectedItem == null)
            {
                MessageBox.Show("Please select a genre.");
                isValid = false;
            }
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex!= -1)
            {
                var selectedSong = (Song)listBoxSongs.SelectedItem;
                var updateSong = new Song
                {
                    Title = textBoxTitle.Text,
                    Artist = textBoxArtist.Text,
                    GenreName = comboBoxGenre.Text,
                    IsAvailable = checkBoxIsAvailable.Checked

                };
                if (string.IsNullOrWhiteSpace(updateSong.GenreName))
                {
                    MessageBox.Show("Please select a genre");
                    return;
                }
                var apiUrl = $"{ApiBaseUrl}/api/song/{selectedSong.SongId}";
                try
                {
                    var json = JsonConvert.SerializeObject(updateSong);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await HttpClient.PutAsync(apiUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Song to update successfully");
                        RefreshListBox();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update song"); 
                        return;
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"An error occurred while updating song {ex.Message}");
                }
            }
        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex != -1)
            {
                var selectedSong = (Song)listBoxSongs.SelectedItem;
                var confirmation = MessageBox.Show("Are you sure you want to delete this song?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    var apiUrl = $"{ApiBaseUrl}/api/song/{selectedSong.SongId}";
                    try
                    {
                        var response = await HttpClient.DeleteAsync(apiUrl);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Song deleted successfully");

                            await LoadGenresAndSongs();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete song.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while delleting song : {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a song to delete.");
                }
            }
        }
        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGenre.SelectedItem != null)
            {
                string selectedGenre = ((KeyValuePair<int, string>)comboBoxGenre.SelectedItem).Value;
                comboBoxGenre.Text = selectedGenre;
            }
        }
    }
}

