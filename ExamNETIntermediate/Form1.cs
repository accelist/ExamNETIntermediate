using ExamNETIntermediate.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Nodes;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        public List<SongModel> SongModels { get; set; } = new List<SongModel>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public HttpClient HttpClient { get; set; } = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            PopulateListSong();
            PopulateComboGenre();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        public async void PopulateListSong()
        {
            var response = await HttpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);

            if (content != null)
            {
                SongModels = content;
            }

            var songSource = new BindingSource
            {
                DataSource = SongModels
            };

            listBoxSong.Items.Clear();
            listBoxSong.Items.AddRange(SongModels.ToArray());
            listBoxSong.DisplayMember = "Title";
        }

        public async void PopulateComboGenre()
        {
            var response = await HttpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<Genre>>(jsonContent);

            if (content != null)
            {
                Genres = content;
            }

            var genreSource = new BindingSource
            {
                DataSource = Genres
            };

            comboBoxGenre.DataSource = genreSource;
            comboBoxGenre.DisplayMember = "GenreName";
        }

        public void ClearInput()
        {
            textBoxTitle.Text = string.Empty;
            textBoxArtist.Text = string.Empty;
            comboBoxGenre.SelectedItem = null;
            numericUpDownSecond.Value = 0;
            numericUpDownMinute.Value = 0;
            dateTimePickerRelease.Value = DateTime.UtcNow;
            checkBoxIsAvailable.Checked = false;
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            ClearInput();
            PopulateListSong();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonAdd.Enabled = true;
        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            var title = textBoxTitle.Text;
            var artist = textBoxArtist.Text;
            var genre = comboBoxGenre.SelectedItem as Genre;
            var minute = numericUpDownMinute.Value * 60;
            var second = numericUpDownSecond.Value;
            var length = minute + second;
            // diubah jadi utc disini
            var releaseDate = dateTimePickerRelease.Value.ToUniversalTime();
            var isAvailable = checkBoxIsAvailable.Checked;

            if (string.IsNullOrEmpty(title))
            {
                labelValidation.Text = "Title must not be empty!";
                return;
            }
            if (string.IsNullOrEmpty(artist))
            {
                labelValidation.Text = "Artist name must not be empty!";
                return;
            }
            if (genre == null)
            {
                labelValidation.Text = "Genre must not be Empty!";
                return;
            }
            if(Genres.Contains(genre) == false)
            {
                labelValidation.Text = "Genre must be in the data genre API!";
                return;
            }
            if (second < 0 || second > 59)
            {
                labelValidation.Text = "Seconds must be between 0 to 59!";
                return;
            }
            if (length == 0)
            {
                labelValidation.Text = "Length must not be empty!";
                return;
            }
            // date picker gk bisa null makanya warning
            if (releaseDate == null)
            {
                labelValidation.Text = "Release date must not be empty!";
                return;
            }
            if (releaseDate >= DateTime.UtcNow.AddDays(7))
            {
                labelValidation.Text = "Release date tidak boleh lebih dari 7 hari ke depan!";
                return;
            }
            // checkbox gk bisa null jga
            if (isAvailable == null)
            {
                labelValidation.Text = "Checkbox isAvailable tidak boleh empty!";
                return;
            }

            var songModel = new SongInputModel
            {
                Title = title,
                Artist = artist,
                GenreId = genre.GenreId,
                Length = Convert.ToInt32(length),
                ReleaseDate = releaseDate,
                IsAvailable = isAvailable,
            };

            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await HttpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelSuccess.Text = "Succesfully inserted New Song";
            }
            else
            {
                labelSuccess.Text = "Failed to insert New Song";
            }
            ClearInput();
            PopulateListSong();
        }

        private void ListBoxSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = false;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
            
            var selectedIndex = listBoxSong.SelectedIndex;
            if (selectedIndex == -1)
            {
                // biar klo gk sengaja klik kosong di listbox gk error
                // sma gk bisa update sma delete
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
                buttonAdd.Enabled = true;
                return;
            }
            var selectedSong = listBoxSong.Items[selectedIndex] as SongModel;
            if (selectedSong == null)
            {
                return;
            }
            textBoxTitle.Text = selectedSong.Title;
            textBoxArtist.Text = selectedSong.Artist;
            var currentSong = Genres.FirstOrDefault(Q => Q.GenreName == selectedSong.GenreName);
            comboBoxGenre.SelectedItem = currentSong;
            var minutes = selectedSong.Length / 60;
            var seconds = selectedSong.Length - (minutes * 60);
            numericUpDownMinute.Value = minutes;
            numericUpDownSecond.Value = seconds;
            dateTimePickerRelease.Value = selectedSong.ReleaseDate.ToUniversalTime();
            checkBoxIsAvailable.Checked = selectedSong.IsAvailable;
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxSong.SelectedIndex;
            var selectedSong = listBoxSong.Items[selectedIndex] as SongModel;
            if (selectedSong == null)
            {
                return ;
            }
            var title = textBoxTitle.Text;
            var artist = textBoxArtist.Text;
            var genre = comboBoxGenre.SelectedItem as Genre;
            var minute = numericUpDownMinute.Value * 60;
            var second = numericUpDownSecond.Value;
            var length = minute + second;
            // diubah jadi utc disini
            var releaseDate = dateTimePickerRelease.Value.ToUniversalTime();
            var isAvailable = checkBoxIsAvailable.Checked;

            if (string.IsNullOrEmpty(title))
            {
                labelValidation.Text = "Title must not be empty!";
                return;
            }
            if (string.IsNullOrEmpty(artist))
            {
                labelValidation.Text = "Artist name must not be empty!";
                return;
            }
            if (genre == null)
            {
                labelValidation.Text = "Genre must not be Empty!";
                return;
            }
            if (Genres.Contains(genre) == false)
            {
                labelValidation.Text = "Genre must be in the data genre API!";
                return;
            }
            if (second < 0 || second > 59)
            {
                labelValidation.Text = "Seconds must be between 0 to 59!";
                return;
            }
            if (length == 0)
            {
                labelValidation.Text = "Length must not be empty!";
                return;
            }
            if (releaseDate == null)
            {
                labelValidation.Text = "Release date must not be empty!";
                return;
            }
            if (releaseDate >= DateTime.UtcNow.AddDays(7))
            {
                labelValidation.Text = "Release date tidak boleh lebih dari 7 hari ke depan!";
                return;
            }
            if (isAvailable == null)
            {
                labelValidation.Text = "Checkbox isAvailable tidak boleh empty!";
                return;
            }

            var songModel = new SongInputModel
            {
                SongId = selectedSong.SongId,
                Title = title,
                Artist = artist,
                GenreId = genre.GenreId,
                Length = Convert.ToInt32(length),
                ReleaseDate = releaseDate,
                IsAvailable = isAvailable,
            };

            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await HttpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelSuccess.Text = "Succesfully updated Song";
            }
            else
            {
                labelSuccess.Text = "Failed to update Song";
            }
            ClearInput();
            PopulateListSong();
        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxSong.SelectedIndex;
            var selectedSong = listBoxSong.Items[selectedIndex] as SongModel;
            if (selectedSong != null)
            {
                var response = await HttpClient.DeleteAsync("https://new-dev.accelist.com:10000/api/song/" + selectedSong.SongId);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    labelSuccess.Text = "Succesfully Deleted Song";
                }
                else
                {
                    labelSuccess.Text = "Failed to delete Song";
                }
                ClearInput();
                PopulateListSong();
            }
            else
            {
                labelValidation.Text = "Must select a song first";
                return;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var input = textBoxSearch.Text;
            if (input == string.Empty)
            {
                PopulateListSong();
                labelVal2.Text = "Search box must not be empty!";
                return;
            }

            var Filtered = SongModels.Where(Q => Q.Title == input || Q.Artist == input).ToList();

            var songSource = new BindingSource
            {
                DataSource = Filtered
            };

            listBoxSong.Items.Clear();
            listBoxSong.Items.AddRange(Filtered.ToArray());
            listBoxSong.DisplayMember = "Title";
        }
    }
}
