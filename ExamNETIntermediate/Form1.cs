using ExamNETIntermediate.Modules;
using Newtonsoft.Json;
using System.Linq;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        // requirement dari penggunaan API
        public HttpClient _httpClient { get; set; } = new HttpClient();

        // list yang menampung data API dengan menggunakan model SongModels
        public List<SongModels> Songs { get; set; } = new List<SongModels>();

        // list yang menampung data API dengan menggunakan model GenreModels
        public List<GenreModels> Genres { get; set; } = new List<GenreModels> { };

        // Initialize Component, Combobox, dan Listbox 
        public Form1()
        {
            InitializeComponent();
            PopulateComboBox();
            PopulateListBox();

        }

        // function untuk mengisi listbox
        public async void PopulateListBox()
        {
            // memanggil link API
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<List<SongModels>>(jsonContent);

            // memasukkan content ke dalam list jika content tidak null
            if (content != null)
            {
                Songs = content;
            }

            // memasukkan data yang telah disimpan ke list ke dalam listbox
            listBoxJudul.DataSource = Songs;
            listBoxJudul.DisplayMember = "Title";

        }

        // function untuk mengisi Combobox
        public async void PopulateComboBox()
        {
            // memanggil link API
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<List<GenreModels>>(jsonContent);

            // memasukkan content ke dalam list jika content tidak null
            if (content != null)
            {
                Genres = content;
            }

            // memasukkan data yang telah disimpan ke list ke dalam listbox
            comboBoxGenre.DataSource = Genres;
            comboBoxGenre.DisplayMember = "GenreName";
        }

        // mengosongkan input field
        public void Clear()
        {
            textBoxArtist.Text = string.Empty;
            textBoxTitle.Text = string.Empty;
            checkBoxIsAvailable.Checked = false;
            comboBoxGenre.SelectedItem = null;
            numericUpDownMinute.Text = "";
            numericUpDownSecond.Text = "";
            dateTimePickerReleaseDate.Value = DateTime.Now;
        }

        // tombol untuk menpost data 
        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            //validasi-validasi yang ditentukan
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                labelNotification.Text = "Name can't be empty";
                return;
            }
            if (string.IsNullOrEmpty(textBoxArtist.Text))
            {
                labelNotification.Text = "Artist can't be empty";
                return;
            }
            if (comboBoxGenre.SelectedItem == null)
            {
                labelNotification.Text = "Genre can't be empty";
                return;
            }
            if (numericUpDownMinute.Text == "")
            {
                labelNotification.Text = "minute can't be empty";
                return;
            }
            if (numericUpDownSecond.Text == "")
            {
                labelNotification.Text = "second can't be empty";
                return;
            }
            if (numericUpDownSecond.Value < 0 || numericUpDownSecond.Value > 59)
            {
                labelNotification.Text = "second must be between 0 and 59";
                return;
            }
            if (numericUpDownMinute.Value == 0 && numericUpDownSecond.Value == 0)
            {
                labelNotification.Text = "Minute and second can't both be 0";
                return;
            }
            var idSent = 0;

            var selected = comboBoxGenre.SelectedItem as GenreModels;
            var selectedGenreId = Genres.Where(Q => Q.GenreName == selected?.GenreName).Select(R => R.GenreId);

            foreach (var item in selectedGenreId)
            {
                idSent = item;
            }
            if (dateTimePickerReleaseDate.Value.Day > DateTime.Today.Day + 7)
            {
                labelNotification.Text = "Must be within 7 Days of the Original release date!";
                return;
            }

            DateTime utc = DateTime.SpecifyKind(dateTimePickerReleaseDate.Value, DateTimeKind.Utc);

            // membuat variable data yang akan di post
            var inputtedData = new SongModelsPost
            {
                SongId = Songs.Count + 1,
                Title = textBoxTitle.Text,
                Artist = textBoxArtist.Text,
                GenreId = idSent,
                Length = Convert.ToInt32(numericUpDownMinute.Value * 60 + numericUpDownSecond.Value),
                ReleaseDate = utc,
                IsAvailable = checkBoxIsAvailable.Checked
            };

            // memanggil API
            var jsonString = JsonConvert.SerializeObject(inputtedData);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);

            // mengecek status panggilan API
            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Succesfully to Insert List";
            }
            else
            {
                labelNotification.Text = "Failed to Insert List";
            }
            PopulateListBox();
        }

        //mendeteksi perubahan index yang dipilih
        private void ListBoxJudul_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = listBoxJudul.SelectedIndex;
            var selectedItem = listBoxJudul.Items[selectedIndex] as SongModels;

            //mengecek apakah selectedItem berisi atau tidak
            if (selectedItem != null)
            {
                textBoxTitle.Text = selectedItem.Title;
                textBoxArtist.Text = selectedItem.Artist;
                comboBoxGenre.SelectedItem = Genres.FirstOrDefault(Q => Q.GenreName == selectedItem.GenreName);
                checkBoxIsAvailable.Checked = selectedItem.IsAvailable;
                numericUpDownMinute.Value = selectedItem.Length / 60;
                numericUpDownSecond.Value = selectedItem.Length % 60;
                dateTimePickerReleaseDate.Value = selectedItem.ReleaseDate;
            }
        }

        //mendeteksi perubahan text pada textbox
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //membuat list penampung baru
            List<SongModels> list = new List<SongModels>();
            //jika textbox ada isi hanya akan memunculkan yang sesuai jika tidak akan memanggil semua
            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                //linq search
                list = Songs.Where(Q => Q.Title.Contains(textBoxSearch.Text) || Q.Artist.Contains(textBoxSearch.Text)).ToList();

                listBoxJudul.DataSource = list;
                listBoxJudul.DisplayMember = "Title";
            }
            else
            {
                //memanggil semua
                PopulateListBox();
            }
        }

        // tombol untuk mendelete data 
        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            //mencari index yang mau dihapus
            var selectedIndex = listBoxJudul.SelectedIndex;

            if (selectedIndex < 0)
            {
                return;
            }

            var selectedName = listBoxJudul.Items[selectedIndex] as SongModels;

            // memanggil API
            var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{selectedName?.SongId}");

            // mengecek status panggilan API
            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Succesfully to Delete List";
            }
            else
            {
                labelNotification.Text = "Failed to Delete List";
            }
            PopulateListBox();
        }

        // tombol untuk menupdate data 
        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //validasi-validasi yang ditentukan
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                labelNotification.Text = "Name can't be empty";
                return;
            }
            if (string.IsNullOrEmpty(textBoxArtist.Text))
            {
                labelNotification.Text = "Artist can't be empty";
                return;
            }
            if (comboBoxGenre.SelectedItem == null)
            {
                labelNotification.Text = "Genre can't be empty";
                return;
            }
            if (numericUpDownMinute.Text == "")
            {
                labelNotification.Text = "minute can't be empty";
                return;
            }
            if (numericUpDownSecond.Text == "")
            {
                labelNotification.Text = "second can't be empty";
                return;

            }
            if (numericUpDownSecond.Value < 0 || numericUpDownSecond.Value > 59)
            {
                labelNotification.Text = "second must be between 0 and 59";
                return;
            }
            if (numericUpDownMinute.Value == 0 && numericUpDownSecond.Value == 0)
            {
                labelNotification.Text = "Minute and second can't both be 0";
                return;
            }
            var idSent = 0;

            var selected = comboBoxGenre.SelectedItem as GenreModels;
            var selectedGenreId = Genres.Where(Q => Q.GenreName == selected?.GenreName).Select(R => R.GenreId);

            var selectedIndex = listBoxJudul.SelectedIndex;
            var selectedSongId = listBoxJudul.Items[selectedIndex] as SongModels;

            foreach (var item in selectedGenreId)
            {
                idSent = item;
            }
            if (dateTimePickerReleaseDate.Value.Day > DateTime.Today.Day + 7)
            {
                labelNotification.Text = "Must be within 7 Days of the Original release date!";
                return;
            }

            foreach (var item in selectedGenreId)
            {
                idSent = item;
            }

            DateTime utc = DateTime.SpecifyKind(dateTimePickerReleaseDate.Value, DateTimeKind.Utc);

            // membuat variable data yang akan di post
            var inputtedData = new SongModelsPost
            {
                SongId = selectedSongId.SongId,
                Title = textBoxTitle.Text,
                Artist = textBoxArtist.Text,
                GenreId = idSent,
                Length = Convert.ToInt32(numericUpDownMinute.Value * 60 + numericUpDownSecond.Value),
                ReleaseDate = utc,
                IsAvailable = checkBoxIsAvailable.Checked
            };

            // memanggil API
            var jsonString = JsonConvert.SerializeObject(inputtedData);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);

            // mengecek status panggilan API
            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Succesfully to Update List";
            }
            else
            {
                labelNotification.Text = "Failed to Update List";
            }
            PopulateListBox();
        }

        // tombol untuk merefresh listbox
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            //memanggil function PopulateListBox();
            PopulateListBox();
        }
    }
}
