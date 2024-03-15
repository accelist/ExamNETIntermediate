using Newtonsoft;
using Newtonsoft.Json;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;
using System.Drawing;

// Ruben Suginato - 2540119526


namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        // Making a new list named Songs, directed to SongModel
        public List<SongModel> Songs { get; set; } = new List<SongModel>();

        // Making a new list named Genres, directed to GenreModel
        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();

        // Making a new list named _httpclient for using HTTP
        public HttpClient _httpClient { get; set; } = new HttpClient();
        public Form1()
        {
            // Calling all the function needed
            InitializeComponent();
            ShowListBox();
            ShowComboBox();
        }

        public async void ShowListBox()
        {
            // Calling all the data from API
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");

            // Check whether its success or not
            response.EnsureSuccessStatusCode();

            // Change from object to json string
            var jsonContent = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);

            // if content is not empty, then assigned to Songs list
            if (content != null)
            {
                Songs = content;
            }

            // If searchbox empty, display Songs list in listBox
            var name = searchBox.Text;
            if (name == string.Empty)
            {
                listBox.DataSource = Songs;
                listBox.DisplayMember = "Title";
            }
            // If searchbox not empty, display listContainNames list in listBox
            else
            {
                var listContainNames = Songs
                    .Where(r => r.Title.Contains(name, StringComparison.OrdinalIgnoreCase)
                    || r.Artist.Contains(name, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                listBox.DataSource = listContainNames;
                listBox.DisplayMember = "Title";
            }
            


        }

        public async void ShowComboBox()
        {
            // Calling all the data from API
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");

            // Check whether its success or not
            response.EnsureSuccessStatusCode();

            // Change from object to json string
            var jsonContent = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<List<GenreModel>>(jsonContent);

            // if content is not empty, then assigned to Genres list
            if (content != null)
            {
                Genres = content;
            }
            
            // ComboBox is filled with content
            comboBoxGenre.DataSource = content;
            comboBoxGenre.DisplayMember = "GenreName";
            comboBoxGenre.ValueMember = "GenreId";
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            // call ListBox
            ShowListBox();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            // Assigned variable and check the condition
            var title = textBoxTitle.Text;
            var artist = textBoxArtist.Text;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Fill in the Title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(artist))
            {
                MessageBox.Show("Fill in the Artist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get genre
            var genre = comboBoxGenre.SelectedItem as GenreModel;
            if (genre == null)
            {
                return;
            }

            // Validation
            if (numericUpDownMinutes.Value == 0 && numericUpDownSeconds.Value == 0)
            {
                MessageBox.Show("Fill in the Minutes and Seconds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericUpDownSeconds.Value < 0 || numericUpDownSeconds.Value > 59)
            {
                MessageBox.Show("Seconds can be only from 0 to 59!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Count minutes and seconds, count to length
            var minutes = numericUpDownMinutes.Value * 60;
            var seconds = numericUpDownSeconds.Value;
            var length = minutes + seconds;

            // Set Date and Validation for 7
            var releaseDate = dateTimePicker.Value.ToUniversalTime();
            var sevenDaysAfter = DateTime.UtcNow.AddDays(7);

            if (releaseDate > sevenDaysAfter)
            {
                MessageBox.Show("Release date must be 7 days from now!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create new model
            var songModel = new SongPostModel
            {
                Title = title,
                Artist = artist,
                GenreId = genre.GenreId,
                Length = ((int)length),
                ReleaseDate = releaseDate,
                IsAvailable = checkBoxAvailable.Checked,
            };
               
            // Insert model to API
            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {

                labelInfo.Text = "Succesfully to Insert New Menu";
                ShowListBox();
            }
            else
            {
                labelInfo.Text = "Failed to Insert New Menu";
            }

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            // Get Index Selected
            var index = listBox.SelectedIndex;

            // Check if there is any selected index
            if (index == -1)
            {
                MessageBox.Show("Please select a menu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Get the location of model in index selected
                var song = listBox.Items[index] as SongModel;

                if (song == null)
                {
                    return;
                }
                
                // Delete it from the API
                var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{song.SongId}");


                if (response.IsSuccessStatusCode)
                {
                    labelInfo.Text = "Delete Success!";
                    ShowListBox();
                }
                else
                {
                    labelInfo.Text = "Failed to delete!";
                }
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Check whether the selected item is there or not
            if (listBox.SelectedItem != null)
            {
                // Assigned variable and check the condition
                var title = textBoxTitle.Text;
                var artist = textBoxArtist.Text;

                if (string.IsNullOrEmpty(title))
                {
                    MessageBox.Show("Fill in the Title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(artist))
                {
                    MessageBox.Show("Fill in the Artist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // New Genre model to get GenreId
                var genre = comboBoxGenre.SelectedItem as GenreModel;
                if (genre == null)
                {
                    return;
                }

                // Validation for length
                if (numericUpDownMinutes.Value == 0 && numericUpDownSeconds.Value == 0)
                {
                    MessageBox.Show("Fill in the Minutes and Seconds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (numericUpDownSeconds.Value < 0 || numericUpDownSeconds.Value > 60)
                {
                    MessageBox.Show("Seconds can be only from 0 to 59!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Count length from data
                var minutes = numericUpDownMinutes.Value * 60;
                var seconds = numericUpDownSeconds.Value;
                var length = minutes + seconds;

                // Get releaseDate from the data and convert it
                var releaseDate = dateTimePicker.Value.ToUniversalTime();
                var sevenDaysAfter = DateTime.UtcNow.AddDays(7);

                // Validation for date
                if (releaseDate > sevenDaysAfter)
                {
                    MessageBox.Show("Release date must be 7 days from now!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // to get song id
                var selectedItem = listBox.SelectedItem as SongModel;
                if (selectedItem == null)
                {
                    return;
                }

                // store check box  variable
                var isAvailable = checkBoxAvailable.Checked;
                
                // assigned all value to model
                var newModel = new SongPostModel
                {
                    SongId = selectedItem.SongId,
                    Title = title,
                    Artist = artist,
                    GenreId = genre.GenreId,
                    Length = ((int)length),
                    IsAvailable = isAvailable,
                    ReleaseDate = releaseDate
                };

                //insert model to API (UPDATE USING PUT)
                var jsonString = JsonConvert.SerializeObject(newModel);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"https://new-dev.accelist.com:10000/api/song", content);

                if (response.IsSuccessStatusCode)
                {
                    labelInfo.Text = "Update Success!";
                    ShowListBox();
                }
                else
                {
                    labelInfo.Text = "Failed to update!";
                }
            }
            else
            {
                MessageBox.Show("Please select a menu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // if any selected item, show button needed
            var selectedItem = listBox.SelectedItem as SongModel;
            if (selectedItem == null)
            {
                buttonDelete.Visible = false;
                buttonUpdate.Visible = false;
                return;
            } else
            {
                addButton.Visible = false;
            }

            var minutes = selectedItem.Length / 60;
            var seconds = selectedItem.Length % 60;

            numericUpDownMinutes.Value = minutes;
            numericUpDownSeconds.Value = seconds;

            textBoxTitle.Text = selectedItem.Title;
            textBoxArtist.Text = selectedItem.Artist;
            checkBoxAvailable.Checked = selectedItem.IsAvailable;

            dateTimePicker.Value = selectedItem.ReleaseDate;

            var currentRestaurant = Genres.FirstOrDefault(r => r.GenreName == selectedItem.GenreName);

            comboBoxGenre.SelectedItem = currentRestaurant;

            
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // call list box
            ShowListBox();
        }

        
    }
}
