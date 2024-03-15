using ExamNETIntermediate.Models;
using Newtonsoft.Json;

namespace ExamNETIntermediate
{
    //TODO add labels for minutes and seconds. Might need additional columns to make it work
    public partial class Form1 : Form
    {
        List<SongModel> songs = new List<SongModel>();
        List<GenreModel> genres = new List<GenreModel>();
        HttpClient httpClient = new HttpClient();
        string baseUrl = "https://new-dev.accelist.com:10000/api";
        public Form1()
        {
            InitializeComponent();
            GetDataListBox();
            GetDataGenre();
        }

        public async void GetDataListBox()
        {
            var response = await httpClient.GetAsync(baseUrl + "/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);
            if (content != null) songs = content;

            //Bisa avoid pake datasource dengan addrange, tapi agak ribet karena harus object. Sementara pake datasource dulu.
            //var contentObject = songs.Cast<Object>().ToArray();
            //listBoxSongs.Items.AddRange(contentObject);
            listBoxSongs.DataSource = songs;
            listBoxSongs.DisplayMember = "title";
        }

        public async void GetDataGenre()
        {
            var response = await httpClient.GetAsync(baseUrl + "/genre");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<GenreModel>>(jsonContent);
            if (content != null) genres = content;

            comboBoxGenre.DataSource = genres;
            comboBoxGenre.DisplayMember = "genreName";
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongModel? selectedItem = listBoxSongs.SelectedItem as SongModel;
            if (selectedItem == null) { return; } //handle null case

            textBoxTitle.Text = selectedItem.Title;
            textBoxArtist.Text = selectedItem.Artist;
            comboBoxGenre.SelectedItem = genres.Where(Q => Q.GenreName == selectedItem.GenreName).FirstOrDefault();
            dateTimePickerReleaseDate.Value = selectedItem.ReleaseDate;
            int minutes = selectedItem.Length / 60;
            int seconds = selectedItem.Length % 60;
            numericUpDownLengthMinutes.Value = minutes;
            numericUpDownLengthSeconds.Value = seconds;
            checkBoxAvailable.Checked = selectedItem.IsAvailable;

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetDataListBox();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            SongModel? selectedItem = listBoxSongs.SelectedItem as SongModel;
            SongModel newItem = new SongModel();
            if(selectedItem == null) { return; }
            GenreModel? inputGenre = comboBoxGenre.SelectedItem as GenreModel;


            //input form validation
            //case: empty|null
            if (string.IsNullOrEmpty(textBoxTitle.Text)
                ||string.IsNullOrEmpty(textBoxArtist.Text)
                || inputGenre == null
                || (numericUpDownLengthMinutes.Value==0 && numericUpDownLengthSeconds.Value == 0))
            {
                labelMessage.Text = "Fields must not be empty!";
                return;
            }
            //case: >7 days
            DateTime currentTime = DateTime.UtcNow;
            TimeSpan timeDiff = dateTimePickerReleaseDate.Value - currentTime;
            if (timeDiff.Days > 7)
            {
                labelMessage.Text = "Release date can not be more than 7 days from now!";
                return;
            }

            newItem.Title = textBoxTitle.Text;
            newItem.Artist = textBoxArtist.Text;
            newItem.GenreName = inputGenre.GenreName;
            newItem.ReleaseDate = dateTimePickerReleaseDate.Value;
            newItem.Length = (int)numericUpDownLengthMinutes.Value * 60 + (int)numericUpDownLengthSeconds.Value;
            newItem.IsAvailable = checkBoxAvailable.Checked;

            newItem.SongId = selectedItem.SongId;
            newItem.ReleaseDate= selectedItem.ReleaseDate;

            //same item validation
            if (newItem.Equals(selectedItem))
            {
                labelMessage.Text = "No changes detected!";
                return;
            }

            //TODO convert to input model
            SongInputModel input = new SongInputModel();
            input.Title = newItem.Title;
            input.Artist = newItem.Artist;
            input.GenreId = inputGenre.GenreId;
            input.ReleaseDate = newItem.ReleaseDate;
            input.Length = newItem.Length;
            input.IsAvailable = newItem.IsAvailable;

            var jsonContent = JsonConvert.SerializeObject(input); 
            var content = new StringContent(jsonContent);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            if (content==null) { return; }

            var response = await httpClient.PostAsync(baseUrl + "/song", content);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                labelMessage.Text = "Song upload successful!";
                GetDataListBox();
            }
            else
            {
                labelMessage.Text = "Song upload failed!";
            }
        }

        private void numericUpDownLengthSeconds_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownLengthSeconds.Value >= 60) //handling seconds overflow into minutes
            {
                numericUpDownLengthSeconds.Value = 0;
                numericUpDownLengthMinutes.Value += 1;
            }
        }
    }
}
