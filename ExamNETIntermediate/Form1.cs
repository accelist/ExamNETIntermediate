using Newtonsoft.Json;
using System.Net.Http;
using ExamNETIntermediate.Models;
using System;
using System.Reflection;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {

        public HttpClient _httpClient { get; set; } = new HttpClient();
        
        /// <summary>
        /// These list if for storing the loaded Songs and Genres to be used in other functions
        /// </summary>
        public List<MusicModel> Songs { get; set; } = new List<MusicModel>();
        public List<Genre> Genres { get; set; } = new List<Genre>();

        /// <summary>
        /// This will run first to load List Box, Combo Box, and Hide the Update and Delete Button
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
            labelNotification.Text = string.Empty;
            PopulateListBox();
            PopulateComboBox();
        }

        /// <summary>
        /// This will run the API to load all the songs available and display the title into the Listbox
        /// </summary>
        public async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<MusicModel>>(jsonContent);

            if (content != null)
            {
                Songs = content;
            }

            listBoxTitle.Items.Clear();
            listBoxTitle.Items.AddRange(Songs.ToArray());
            listBoxTitle.DisplayMember = "Title";
        }

        /// <summary>
        /// This will run the API to get the Genres available to be displayed in the combo box
        /// </summary>
        public async void PopulateComboBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<Genre>>(jsonContent);

            if (content != null)
            {
                Genres = content;
            }

            comboBoxGenre.Items.Clear();
            comboBoxGenre.Items.AddRange(Genres.ToArray());

            comboBoxGenre.DisplayMember = "GenreName";
            comboBoxGenre.ValueMember = "GenreId";
            comboBoxGenre.SelectedIndex = -1;
        }

        /// <summary>
        /// This will validate the input and send the new song into the API 
        /// </summary>
        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var songName = textBoxTitle.Text;
            var artistName = textBoxArtist.Text;
            int songLengthMinute = (int)numericUpDownLengthMinute.Value;
            int songLengthSecond = (int)numericUpDownLengthSecond.Value;
            var selectedGenre = comboBoxGenre.SelectedItem as Genre;
            var releaseDate = dateTimePickerReleaseDate.Value.ToUniversalTime();

            if (string.IsNullOrEmpty(songName))
            {
                labelNotification.Text = "Title can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(artistName))
            {
                labelNotification.Text = "Artist can't be empty";
                return;
            }

            if (selectedGenre == null)
            {
                labelNotification.Text = "Please select a restaurant";
                return;
            }

            if (songLengthSecond > 60 || (songLengthSecond == 0 && songLengthMinute == 0))
            {
                labelNotification.Text = "Input a Valid Length!";
                return;
            }

            if (dateTimePickerReleaseDate.Value > DateTime.UtcNow.AddDays(7))
            {
                labelNotification.Text = "Input a valid Date";
                return;
            }

            int Length = songLengthMinute * 60 + songLengthSecond;

            var menuModel = new MusicInputModel
            {
                Title = songName,
                Artist = artistName,
                GenreId = selectedGenre.GenreId,
                Length = Length,
                ReleaseDate = releaseDate,
                IsAvailable = checkBoxAvailable.Checked,
            };


            var jsonString = JsonConvert.SerializeObject(menuModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                ClearAll();
                labelNotification.Text = "Successfully Insert New Song";
                PopulateListBox();
            }
            else
            {
                labelNotification.Text = "Failed to Insert New Song";
            }
        }

        /// <summary>
        /// This will clear all selection and input for the numeric and dateTimePicker will be changed to the default value
        /// </summary>
        public void ClearAll()
        {
            PopulateListBox();
            textBoxTitle.Text = string.Empty;
            textBoxArtist.Text = string.Empty;
            checkBoxAvailable.Checked = false;
            comboBoxGenre.SelectedIndex = -1;
            numericUpDownLengthMinute.Value = 0;
            numericUpDownLengthSecond.Value = 0;
            listBoxTitle.ClearSelected();
            labelNotification.Text = string.Empty;
            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
            textBoxSearch.Text = string.Empty;
            dateTimePickerReleaseDate.Value = DateTime.Now;
        }

        /// <summary>
        /// This will delete the selected song on the list box from the api
        /// </summary>
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            var index = listBoxTitle.SelectedIndex;

            if (index == -1)
            {
                labelNotification.Text = "Selected Index Doesn't Exist";
            }
            var musicId = listBoxTitle.Items[index] as MusicModel;
            var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{musicId.SongId}");

            if (response.IsSuccessStatusCode)
            {
                ClearAll();
                labelNotification.Text = "Entry deleted successfully.";
                PopulateListBox();
            }
            else
            {
                Console.WriteLine("Failed to delete entry.");
            }
        }

        /// <summary>
        /// This will validate the input (just like in Add) and will replace the selected song in the list box with the new one
        /// </summary>
        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            var songName = textBoxTitle.Text;
            var artistName = textBoxArtist.Text;
            int songLengthMinute = (int)numericUpDownLengthMinute.Value;
            int songLengthSecond = (int)numericUpDownLengthSecond.Value;
            var selectedGenre = comboBoxGenre.SelectedItem as Genre;
            var releaseDate = dateTimePickerReleaseDate.Value.ToUniversalTime();

            var index = listBoxTitle.SelectedIndex;
            var musicId = listBoxTitle.Items[index] as MusicModel;


            if (string.IsNullOrEmpty(songName))
            {
                labelNotification.Text = "Title can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(artistName))
            {
                labelNotification.Text = "Artist can't be empty";
                return;
            }

            if (selectedGenre == null)
            {
                labelNotification.Text = "Please select a restaurant";
                return;
            }

            if (songLengthSecond > 60 || (songLengthSecond == 0 && songLengthMinute == 0))
            {
                labelNotification.Text = "Input a Valid Length!";
                return;
            }

            if (dateTimePickerReleaseDate.Value > DateTime.UtcNow.AddDays(7))
            {
                labelNotification.Text = "Input a valid Date";
                return;
            }

            int Length = songLengthMinute * 60 + songLengthSecond;

            var menuModel = new MusicInputModel
            {
                SongId = musicId.SongId,
                Title = songName,
                Artist = artistName,
                GenreId = selectedGenre.GenreId,
                Length = Length,
                ReleaseDate = releaseDate,
                IsAvailable = checkBoxAvailable.Checked,
            };


            var jsonString = JsonConvert.SerializeObject(menuModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                ClearAll();
                
                PopulateListBox();
                labelNotification.Text = "Successfully Update a Song";
            }
            else
            {
                labelNotification.Text = "Failed to Insert New Song";
            }
        }

        /// <summary>
        /// This will display the data of the songs of the selected song in list box to the input
        /// </summary>
        private void listBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;

            var selectedItem = listBoxTitle.SelectedItem as MusicModel;

            if (selectedItem == null)
            {
                return;
            }

            textBoxTitle.Text = selectedItem.Title;
            textBoxArtist.Text = selectedItem.Artist;
            checkBoxAvailable.Checked = selectedItem.IsAvailable;
            numericUpDownLengthMinute.Value = selectedItem.Length / 60;
            numericUpDownLengthSecond.Value = selectedItem.Length % 60;

            var name = selectedItem.GenreName;
            var currentRestaurant = Genres.FirstOrDefault(Q => Q.GenreName == selectedItem.GenreName);

            comboBoxGenre.SelectedItem = currentRestaurant;
        }

        /// <summary>
        /// This button is for clearing the input with the ClearAll function from before
        /// </summary>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        /// <summary>
        /// This will make a new list that will copy from the Songs list based on the input search (search can be the title or genre or artis) and will be displayed into the list box
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text == string.Empty)
            {
                PopulateListBox();
                ClearAll();
            }
            else
            {
                string searchQuery = textBoxSearch.Text.ToLower();

                var results = Songs.Where(song =>
                    song.Title.ToLower().Contains(searchQuery) ||
                    song.Artist.ToLower().Contains(searchQuery)
                ).ToList();

                listBoxTitle.Items.Clear();
                listBoxTitle.Items.AddRange(results.ToArray());

                if (results.Count == 0)
                {
                    labelNotification.Text = "No matching songs found.";
                }
                else
                {
                    labelNotification.Text = $"{results.Count} Song(s) Found";
                }
            }
        }
    }
}
