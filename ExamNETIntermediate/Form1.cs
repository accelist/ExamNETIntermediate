using ExamNETIntermediate.Model;
using Newtonsoft.Json;
using System.Text;
using System.ComponentModel;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Security;
using Microsoft.VisualBasic;
//Robertus Ferdinand
namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {


        public List<GenreModel> Genre { get; set; } = new List<GenreModel>();
        public List<SongModel> Song { get; set; } = new List<SongModel>();
        public HttpClient _httpClient { get; set; } = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            PopulateComboBox();
            PopulateListBox();
            /*dateTimePicker.MinDate =DateTime.Today;
            dateTimePicker.MaxDate =DateTime.Today.AddDays(7);*/
        }

        public async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);
            if (content != null)
            {
                Song = content;
            }
            listBoxMenu.Items.Clear();
            listBoxMenu.Items.AddRange(Song.ToArray());
            listBoxMenu.DisplayMember = "Title";

        }

        public async void PopulateComboBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<GenreModel>>(jsonContent);
            if (content != null)
            {
                Genre = content;
            }
            comboBoxGenre.Items.Clear();
            comboBoxGenre.Items.AddRange(Genre.ToArray());
            comboBoxGenre.DisplayMember = "GenreName";

        }

        public void RefreshBtn_Click(object sender, EventArgs e)
        {
             PopulateListBox();
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            var songTitle = textBoxTitle.Text;
            var artistName = textBoxArtis.Text;
            int minute = (int)numericUpDownMenit.Value;
            int seconds = (int)numericUpDownSeconds.Value;
            int totalDuration = (minute * 60) + seconds;
            DateTime currentDate = dateTimePicker.Value;

            //validate each conditions
            if (seconds == 0)
            {
                labelNotification.Text = "Duration Cannot be Empty!";
                return;
            }
            if (currentDate > DateTime.Now.AddDays(7)||currentDate < DateTime.Now.AddDays(-7))
            {
                labelNotification.Text = "Please Select a date within the next 7 days !";
                return;
            }
            if (minute == 0)
            {   
                labelNotification.Text = "Duration Cannot Be Empty!";
                return;
            }
            if (string.IsNullOrEmpty(songTitle))
            {
                labelNotification.Text = "Song Title Cannot Be Empty!";
                return;
            }
            if (string.IsNullOrEmpty(artistName))   
            {
                labelNotification.Text = "Artist Name Cannot Be Empty!";
                return;
            }
            if(!checkBoxAvailable.Checked)
            {
                labelNotification.Text = "Please Mark the checkbox!";
                return;
            }
            var selectedGenre = comboBoxGenre.SelectedItem as GenreModel;
            if (selectedGenre == null)
            {
                labelNotification.Text = "Please select a genre!";
                return;
            }
        
            var songModel = new SongModelInput
            {
                Title = songTitle,
                Artist = artistName,
                Length = totalDuration,
                IsAvailable = checkBoxAvailable.Checked,
                ReleaseDate = currentDate,
                GenreId = selectedGenre.GenreId
            };

            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Successfully Inserted to new menu!";
            }
            else
            {
                labelNotification.Text = "Failed to Insert New Menu!";
            }

            PopulateListBox();
            ClearInput();
        }

        public void ClearInput()
        {
            textBoxArtis.Text = string.Empty;
            textBoxTitle.Text = string.Empty;
            comboBoxGenre.SelectedItem = null;
            checkBoxAvailable.Checked = false;
            numericUpDownMenit.Value = 0;
            numericUpDownSeconds.Value = 0;
            dateTimePicker.Value = DateTime.Now;

        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedItem != null)
            {
                if (listBoxMenu.SelectedItem is SongModel selectedSong)
                {
                    string titleNameUp = textBoxTitle.Text;
                    string artistNameUp = textBoxArtis.Text;
                    bool updateAvail = checkBoxAvailable.Checked;
                    int minute = (int)numericUpDownMenit.Value;
                    DateTime releasedDate = dateTimePicker.Value;
                    int seconds = (int)numericUpDownSeconds.Value;
                    int totalDuration = (minute * 60) + seconds;

                    if (releasedDate > DateTime.Now.AddDays(7) || releasedDate < DateTime.Now)
                    {
                        labelNotification.Text = "Please Select a date within the next 7 days range !";
                        return;
                    }
                    SongModelInput updateSong = new SongModelInput
                    {
                        SongId = Convert.ToInt32(selectedSong.SongId),
                        Title = titleNameUp,
                        Artist = artistNameUp,
                        GenreId = comboBoxGenre.SelectedIndex + 1,
                        Length = totalDuration,
                        ReleaseDate = releasedDate,
                        IsAvailable = updateAvail
                    };
                    string json = JsonConvert.SerializeObject(updateSong);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);

                    if (response.IsSuccessStatusCode)
                    {
                        labelNotification.Text = "Song Updated!";
                        PopulateListBox();
                    }
                    else
                    {
                        labelNotification.Text = $"Failed";
                    }
                }
                else
                {
                    labelNotification.Text = "Invalid selection.";
                }
            }
            else
            {
                labelNotification.Text = "No item selected.";
            }

            PopulateListBox();
        }


        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedItem != null)
            {
                SongModel selectedSong = (SongModel)listBoxMenu.SelectedItem;
                HttpResponseMessage response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{selectedSong.SongId}");
                if (response.IsSuccessStatusCode)
                {
                    labelNotification.Text = "Deleted";
                    PopulateListBox();
                }
                else
                {
                    labelNotification.Text = "Rejected";
                }
            }
            else
            {
                labelNotification.Text = "There's nothing to Delete!";

            }
             PopulateListBox();
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedItem != null)
            {
                var selectedItem = listBoxMenu.SelectedItem as SongModel;

                if (selectedItem != null)
                {
                    var selectedSong = Genre.FirstOrDefault(items => items.GenreName == selectedItem.GenreName);

                    if (selectedSong != null)
                    {
                        DateTime currentDate = selectedItem.ReleaseDate;
                        int minute = selectedItem.Length / 60;
                        int seconds = selectedItem.Length % 60;

                        textBoxTitle.Text = selectedItem.Title;
                        textBoxArtis.Text = selectedItem.Artist;
                        checkBoxAvailable.Checked = selectedItem.IsAvailable;
                        comboBoxGenre.SelectedItem = selectedSong;
                        numericUpDownMenit.Value = Convert.ToInt32(minute);
                        numericUpDownSeconds.Value = Convert.ToInt32(seconds);
                        dateTimePicker.Value = currentDate;
                    }
                    else
                    {
                        labelNotification.Text = "Selected song's genre not found!";
                        return;
                    }
                }
                else
                {
                    labelNotification.Text = "Choose songs first!";
                    return;
                }
            }
            else
            {
                labelNotification.Text = "Choose An item!";
                return;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var search = searchBox.Text;
            var searchItem = Song.Where(items => items.Title.Contains(search) || items.Artist.Contains(search)).ToList();
            listBoxMenu.DataSource = searchItem;
            listBoxMenu.DisplayMember = "Title";

        }
      
    }
}
