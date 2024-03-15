using ExamNETIntermediate.Models;
using Newtonsoft.Json;

namespace ExamNETIntermediate
{
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
            if(selectedItem == null) { return; } //handle null case

            textBoxTitle.Text = selectedItem.Title;
            textBoxArtist.Text = selectedItem.Artist;
            int minutes = selectedItem.Length / 60;
            int seconds = selectedItem.Length % 60;
            numericUpDownLengthMinutes.Value = minutes;
            numericUpDownLengthSeconds.Value = seconds;
            checkBoxAvailable.Checked = selectedItem.IsAvailable;

            comboBoxGenre.SelectedItem = genres.Where(Q => Q.GenreName == selectedItem.GenreName).FirstOrDefault();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetDataListBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        
    }
}
