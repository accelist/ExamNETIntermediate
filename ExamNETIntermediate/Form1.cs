using ExamNETIntermediate.Models;
using Newtonsoft.Json;
using Newtonsoft;
using System.Windows.Forms;
using System.Text;

namespace ExamNETIntermediate
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Berikut adalah untuk membuat List Songs dari Model SongModel yang telah dibuat.
        /// Dilakukan hal yang sama tetapi List Genres dari Model Genre (ini adalah untuk ComboBox)
        /// dan yang terakhir memanggil HttpClient agar bisa terhubung ke API.
        /// </summary>
        public List<SongModel> Songs { get; set; } = new List<SongModel>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public HttpClient _httpClient { get; set; } = new HttpClient();

        /// <summary>
        /// Agar bisa run Windows Form Appnya, memanggil PopulateListBox untuk menunjukkan ListBox,
        /// dan ComboBox untuk Genre juga. Lalu ada declare NumericUpDown untuk detik agar tidak
        /// melebihi 60.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            PopulateListBox();
            ComboBoxGenre();
            detikNumericUpDown.Maximum = 60;
        }

        /// <summary>
        /// Berikut adalah function ListBox, disini saya memanggil API untuk mendapatkan datanya dari
        /// swagger, agai ditampilkan judul lagunya di ListBox. Saya juga menambahkan method ClearSelected()
        /// agar ketika masuk ke Form App, tidak terotomatis select lagu yang ada di ListBox.
        /// </summary>
        public async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<List<SongModel>>(jsonContent);

            if (content != null)
            {
                Songs = content;
            }

            listBoxSong.DataSource = Songs;
            listBoxSong.DisplayMember = "Title";
            listBoxSong.ClearSelected();
        }

        /// <summary>
        /// berikut adalah function untuk Refresh Button agar ListBox terRefresh dari APInya.
        /// </summary>

        private void refreshButton_Click(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        /// <summary>
        /// Berikut adalah button untuk Add yaitu menambah Lagu ke ListBox. Disini saya declare
        /// Title, Artist, Genre, NumericUpDown untuk menit dan detik, dan hasil detik secara keseluruhannya
        /// juga ReleaseDate, dimana ada validasi untuk masing2 atribut. Contohnya kalau
        /// Title masih kosong, muncul notifikasi bahwa title tidak boleh kosong, ReleaseDate maksimal tidak boleh
        /// di atas 7 hari.
        /// </summary>

        private async void addButton_Click(object sender, EventArgs e)
        {
            var songTitle = titleTextBox.Text;
            var songArtist = artistTextBox.Text;
            var songGenre = genreComboBox.Text;
            var songAvailable = availableCheckBox.Checked;
            var minutes = (int)menitNumericUpDown.Value;
            var seconds = (int)detikNumericUpDown.Value;

            var totalSeconds = (minutes * 60) + seconds;
            var songLength = totalSeconds;

            var releaseDateInput = releaseDate.Value.ToUniversalTime();
            var max7Days = DateTimeOffset.UtcNow.AddDays(7);

            if (string.IsNullOrEmpty(songTitle))
            {
                labelNotification.Text = "The Title of the Song can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(songArtist))
            {
                labelNotification.Text = "The Artist of the Song can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(songGenre))
            {
                labelNotification.Text = "The Genre of the Song can't be empty";
                return;
            }

            //Berikut adalah untuk jaga-jaga dari soal dikatakan bahwa IsAvailability tidak boleh kosong
            //Kalau IsAvailability tidak dicentang, berarti tidak available lagunya dan tidak bisa
            //di-add.

            //if(songAvailable == false)
            //{
            //    labelNotification.Text = "Song must be Available, Check the Box";
            //    return;
            //}

            if (songLength == 0)
            {
                labelNotification.Text = "Length can't be empty";
                return;
            }

            if (releaseDateInput > max7Days)
            {
                labelNotification.Text = "Release Date must be 7 Days Max";
                return;
            }

            var songModel = new SongInputModel
            {
                SongId = 1,
                Title = songTitle,
                Artist = songArtist,
                GenreId = 1,
                Length = songLength,
                ReleaseDate = DateTimeOffset.Now,
                IsAvailable = availableCheckBox.Checked,
            };

            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Succesfully to Insert New Song";
                PopulateListBox();
            }
            else
            {
                labelNotification.Text = "Failed to Insert New Song";
            }
        }

        /// <summary>
        /// Berikut adalah function Combo Box untuk Genre saya dimana datanya diambil dari API,
        /// jadi kalau ComboBox didropdown, hanya akan muncul pilihan yang ada di API.
        /// </summary>

        public async void ComboBoxGenre()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/genre");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<Genre>>(jsonContent);

            Genres = content;
            var menuBindingSource = new BindingSource
            {
                DataSource = Genres
            };

            genreComboBox.DataSource = menuBindingSource;
            genreComboBox.DisplayMember = "GenreName";
            genreComboBox.ValueMember = "GenreId";
        }

        /// <summary>
        /// Berikut adalah function ketika judul lagu yang diselect di ListBox itu akan terjadi
        /// kondisi-kondisi seperti ketika lagu tidak diselect, button untuk update dan delete akan
        /// hilang karena belum ada lagu yang ingin perbuat aksi. Kalau diselect baru muncul.
        /// Di sini saya pakai != -1 yang artinya -1 itu berarti tidak ada yang diselect, jadi
        /// dengan != yang artinya 'tidak sama dengan', artinya tidak ada yang tidak diselect, artinya
        /// ada yang diselect dari ListBox oleh karena ini visiblity untuk button update dan delete jadi true.
        /// 
        /// Lalu di bawah line of code tersebut ada line of codes untuk menunjukkan hasil inputtan
        /// yang user sudah input untuk lagu yang diselect di ListBox. Contohnya ketika title lagu
        /// yang di select adalah 'A', lalu textbox inputtan di kanan ListBox akan berisi semua detail
        /// tentang apa yang user input, termasuk Menit dan Detik (yang sudah diconvert kembali dari Length
        /// dikarenakan Length membutuhkan value detik saja) releasedate juga.
        /// </summary>

        private void listBoxSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSong.SelectedIndex != -1)
            {
                updateButton.Visible = true;
                deleteButton.Visible = true;
            }
            else
            {
                updateButton.Visible = false;
                deleteButton.Visible = false;
            }

            var selectedItem = listBoxSong.SelectedItem as SongModel;
            if (selectedItem == null) return;
            titleTextBox.Text = selectedItem.Title;
            artistTextBox.Text = selectedItem.Artist;
            availableCheckBox.Checked = selectedItem.IsAvailable;
            var thisGenre = Genres.FirstOrDefault(Q => Q.GenreName == selectedItem.GenreName);
            genreComboBox.SelectedItem = thisGenre;
            menitNumericUpDown.Value = selectedItem.Length / 60;
            detikNumericUpDown.Value = selectedItem.Length % 60;
        }

        /// <summary>
        /// Berikut adalah function untuk delete lagu di ListBox, Apa yang diselect lalu diklik tombol
        /// deletenya, lagu tersebut akan kedelete.
        /// </summary>

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxSong.SelectedIndex;

            if (selectedItem == -1)
            {
                actionLabel.Text = "Can't find selected item";
            }

            var songId = listBoxSong.Items[selectedItem] as SongModel;
            var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{songId.SongId}");

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Deleted successfully");
                PopulateListBox();
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        /// <summary>
        /// Berikut adalah function untuk update lagu yang ada di ListBox, mirip seperti Add function
        /// tetapi kita harus select lagu yang ada di ListBox, dan kalau tombol update diklik lagu yang
        /// diselect akan berubah sesuai dengan inputtan barunya kita.
        /// </summary>

        private async void updateButton_Click(object sender, EventArgs e)
        {
            var songName = titleTextBox.Text;
            var artistName = artistTextBox.Text;
            var songGenre = genreComboBox.Text;
            var minutes = (int)menitNumericUpDown.Value;
            var seconds = (int)detikNumericUpDown.Value;
            var totalSeconds = (minutes * 60) + seconds;
            var songLength = totalSeconds;
            var selectedItem = listBoxSong.SelectedIndex;

            if (selectedItem == -1)
            {
                actionLabel.Text = "Can't find selected item";
            }
            var songId = listBoxSong.Items[selectedItem] as SongModel;

            if (string.IsNullOrEmpty(songName))
            {
                labelNotification.Text = "Menu Name can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(artistName))
            {
                labelNotification.Text = "Food theme can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(songGenre))
            {
                labelNotification.Text = "The Genre of the Song can't be empty";
                return;
            }

            if (songLength == 0)
            {
                labelNotification.Text = "Length can't be empty";
                return;
            }
            var songModel = new SongInputModel
            {
                SongId = songId.SongId,
                Title = songName,
                Artist = artistName,
                GenreId = 1,
                Length = songLength,
                ReleaseDate = DateTimeOffset.Now,
                IsAvailable = availableCheckBox.Checked,
            };
            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Deleted successfully");
                PopulateListBox();
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        /// <summary>
        /// Berikut adalah function untuk search lagu, jadi ketika kita ketik lagu yang ingin dicari
        /// di textbox Search di atas ListBox, dan ketika kita klik tombol 'Search', lagu yang kita
        /// cari akan muncul di ListBox, dan yang tidak sesuai dengan hasil searchnya kita akan hilang
        /// saya menggunakan ToLower(), agar tidak case sensitive agar user dapat menggunakan search tool
        /// ini dengan nyaman.
        /// </summary>

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchSong = searchTextBox.Text.ToLower();
            var currentSong = Songs.Where(Q => Q.Title.ToLower().Contains(searchSong) || Q.Artist.ToLower().Contains(searchSong)).ToList();
            listBoxSong.DataSource = currentSong;
            listBoxSong.DisplayMember = "Title";
        }

        /// <summary>
        /// Berikut adalah function untuk clear hasil inputtan. Jadi textbox di kanan ListBox akan balik jadi
        /// default.
        /// </summary>

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = string.Empty;
            artistTextBox.Text = string.Empty;
            genreComboBox.SelectedItem = null;
            availableCheckBox.Checked = false;
            menitNumericUpDown.Value = 0;
            detikNumericUpDown.Value = 0;
            releaseDate.Value = DateTime.Now;
        }
    }
}
