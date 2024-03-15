using ExamNETIntermediate.Models;
using Newtonsoft;
using Newtonsoft.Json;
using System.Linq;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        public List<MusicModel> Musics { get; set; } = new List<MusicModel>();
        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();

        public HttpClient _httpClient { get; set; } = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxGenre();
            PopulateListBox();

            DisabledButton();

        }

        public void DisabledButton()
        {
            ButtonDelete.Enabled = false;
            ButtonUpdate.Enabled = false;
        }
        public async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            //var content = JsonSerializer.Deserialize<List<MenuModel>>(jsonContent);

            var content = JsonConvert.DeserializeObject<List<MusicModel>>(jsonContent);

            if (content != null)
            {
                Musics = content;
            }
            ListBoxMusicCollection.Items.Clear();
            ListBoxMusicCollection.Items.AddRange(Musics.ToArray());
            ListBoxMusicCollection.DisplayMember = "title";
        }

        public async void PopulateComboBoxGenre()
        {

            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            //var content = JsonSerializer.Deserialize<List<MenuModel>>(jsonContent);

            var content = JsonConvert.DeserializeObject<List<GenreModel>>(jsonContent);

            if (content != null)
            {
                Genres = content;
            }

            ComboBoxGenre.Items.AddRange(Genres.ToArray());
            ComboBoxGenre.DisplayMember = "genreName";
            ComboBoxGenre.SelectedItem = null;
        }
        public void ClearInput()
        {
            TextBoxSongTitle.Text = string.Empty;
            TextBoxArtist.Text = string.Empty;
            ComboBoxGenre.SelectedItem = null;
            NumericUpDownMin.Value = 0;
            NumericUpDownSec.Value = 0;
            DateTimePickerReleaseDate.Value = DateTime.UtcNow; 
            CheckBoxIsAvailable.Checked = false;
        }

        private async void ButtonAddMusic_Click(object sender, EventArgs e)
        {
            var songTitle = TextBoxSongTitle.Text;
            var artistName = TextBoxArtist.Text;
            var songLength = NumericUpDownMin.Value * 60 + NumericUpDownSec.Value;
            var genre = ComboBoxGenre.SelectedIndex;
            var songReleaseDate = DateTimePickerReleaseDate.Value.ToUniversalTime(); 
            var songIsAvailable = CheckBoxIsAvailable.Checked;

            if (string.IsNullOrEmpty(songTitle))
            {
                LabelNotification.Text = "Title can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(artistName))
            {
                LabelNotification.Text = "Artist can't be empty";
                return;
            }
            if (ComboBoxGenre == null)
            {
                LabelNotification.Text = "Genre can't be empty";
                return;
            }
            if (NumericUpDownMin.Value == 0)
            {
                LabelNotification.Text = "Minutes can't be empty";
                return;
            }
            if (NumericUpDownSec.Value == 0)
            {
                LabelNotification.Text = "Seconds can't be empty";
                return;
            }

            if (songReleaseDate == null)
            {
                LabelNotification.Text = "Release date can't be empty";
                return;
            }
            else if (songReleaseDate > DateTime.UtcNow.AddDays(7))
            {
                LabelNotification.Text = "Release date can't be over 7 days";
                return;
            }


            if (songIsAvailable != true)
            {
                LabelNotification.Text = "Availability can't be empty";
                return;
            }

            var musicModel = new MusicInputModel
            {
                title = songTitle,
                artist = artistName,
                genreId = (ComboBoxGenre.SelectedItem as GenreModel).genreId,
                length = ((int)songLength),
                releaseDate = songReleaseDate,
                isAvailable = songIsAvailable

            };

            var jsonString = JsonConvert.SerializeObject(musicModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                LabelNotification.Text = "Succesfully to Insert New Song";
            }
            else
            {
                LabelNotification.Text = "Failed to Insert New Song";
            }
            ClearInput();

            PopulateListBox();



        }

        private void NumericUpDownSec_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownSec.Maximum = 60;
            if (NumericUpDownSec.Value == 60)
            {
                NumericUpDownMin.Value += 1;
                NumericUpDownSec.Value = 0;
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        private void ListBoxMusicCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ListBoxMusicCollection.SelectedIndex;
            var selectedMusic = ListBoxMusicCollection.Items[selectedIndex] as MusicModel;
            var selectedGenre = Genres.Where(q => q.genreName == selectedMusic.genreName).FirstOrDefault();

           
            if (selectedMusic != null)
            {
                TextBoxSongTitle.Text = selectedMusic.title;
                TextBoxArtist.Text = selectedMusic.artist;
                ComboBoxGenre.SelectedItem = selectedGenre;
                NumericUpDownMin.Value = selectedMusic.length / 60;
                NumericUpDownSec.Value = selectedMusic.length % 60;
                DateTimePickerReleaseDate.Value = selectedMusic.releaseDate.ToUniversalTime();
                CheckBoxIsAvailable.Checked = selectedMusic.isAvailable;

                ButtonDelete.Enabled = true;
                ButtonUpdate.Enabled = true;
            }
            else
            {
                DisabledButton();
            }
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            var selectedIndex = ListBoxMusicCollection.SelectedIndex;
            var selectedMusic = ListBoxMusicCollection.Items[selectedIndex] as MusicModel;
            var selectedSong = ListBoxMusicCollection.SelectedItem as MusicModel;
            var selectedGenre = Genres.Where(q => q.genreName == selectedMusic.genreName).FirstOrDefault();

            

            var songTitle = TextBoxSongTitle.Text;
            var artistName = TextBoxArtist.Text;
            var songLength = NumericUpDownMin.Value * 60 + NumericUpDownSec.Value;
            var genre = ComboBoxGenre.SelectedIndex;
            var songReleaseDate = DateTimePickerReleaseDate.Value.ToUniversalTime();
            var songIsAvailable = CheckBoxIsAvailable.Checked;

            
            
            if (string.IsNullOrEmpty(songTitle))
            {
                LabelNotification.Text = "Title can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(artistName))
            {
                LabelNotification.Text = "Artist can't be empty";
                return;
            }
            if (ComboBoxGenre == null)
            {
                LabelNotification.Text = "Genre can't be empty";
                return;
            }
            if (NumericUpDownMin.Value == 0)
            {
                LabelNotification.Text = "Minutes can't be empty";
                return;
            }
            if (NumericUpDownSec.Value == 0)
            {
                LabelNotification.Text = "Seconds can't be empty";
                return;
            }

            if (songReleaseDate == null)
            {
                LabelNotification.Text = "Release date can't be empty";
                return;
            }
            else if (songReleaseDate > DateTime.UtcNow.AddDays(7))
            {
                LabelNotification.Text = "Release date can't be over 7 days";
                return;
            }


            if (songIsAvailable != true)
            {
                LabelNotification.Text = "Availability can't be empty";
                return;
            }
            
            

            var musicModel = new MusicEditModel
            {
                songId = selectedSong.songId,
                title = songTitle,
                artist = artistName,
                genreId = (ComboBoxGenre.SelectedItem as GenreModel).genreId,
                length = ((int)songLength),
                releaseDate = songReleaseDate,
                isAvailable = songIsAvailable

            };
            var jsonString = JsonConvert.SerializeObject(musicModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


            var response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                LabelNotification.Text = "Succesfully to Update Music in Collection";
            }
            else
            {
                LabelNotification.Text = "Failed to Update Music in Collection";
            }

            PopulateListBox();
            ClearInput();
            DisabledButton();
            TextBoxFind.Clear();

        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            var selectedIndex = ListBoxMusicCollection.SelectedIndex;
            var selectedMusic = ListBoxMusicCollection.Items[selectedIndex] as MusicModel;

            if (selectedMusic == null)
            {
                LabelNotification.Text = "Can't find selected song";
                return;
            }

            Musics.Remove(selectedMusic);


            var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{selectedMusic.songId}");
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                LabelNotification.Text = "Succesfully Delete Song";
            }
            else
            {
                LabelNotification.Text = "Failed Delete Song";
            }

            PopulateListBox();
            ClearInput();
            DisabledButton();
            TextBoxFind.Clear();
        }

        private void TextBoxFind_TextChanged(object sender, EventArgs e)
        {
            var searchSong = TextBoxFind.Text.ToLower();
            var filteredMusic = Musics.Where(music =>
                music.title.ToLower().Contains(searchSong) ||
                music.artist.ToLower().Contains(searchSong)
            ).ToList();

            ListBoxMusicCollection.Items.Clear();
            ListBoxMusicCollection.Items.AddRange(filteredMusic.ToArray());
            ListBoxMusicCollection.DisplayMember = "title";

            
        }
       
        

    }

}
