using Newtonsoft;
using Newtonsoft.Json;

namespace ExamNETIntermediate
{

    public partial class Form1 : Form
    {
        
        //Define an instance of Model to help storing data.
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public HttpClient _httpClient { get; set; } = new HttpClient();
        //Define a field called DateMaximal for conditional maximum 7 days.
        private DateTimeOffset DateMaximal { get; } = DateTimeOffset.Now.AddDays(7);

        //Constructor
        public Form1()
        {
            InitializeComponent();
            PopulateListBox();
            PopulateGenreComboBox();
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            labelNotification.Visible = false;
        }
        //Methods

        /// <summary>
        /// To Clear Inputs
        /// </summary>
        private void ClearBox()
        {
            textBoxTitle.Text = string.Empty;
            textBoxArtist.Text = string.Empty;
            comboBoxGenre.Text = string.Empty;
            numericUpDownMinutes.Value = 0;
            numericUpDownSeconds.Value = 0;
            listBoxSongList.SelectedItem = null;
            checkBoxIsAvailable.Checked = false;
            buttonAdd.Visible = true;
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;

        }

        /// <summary>
        /// To Calling API storing data for ComboBox(genre) and ListBox(song) 
        /// </summary>
        private async void PopulateGenreComboBox()
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
        }
        private async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:10000/api/song");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<Song>>(jsonContent);

            //Storing content to songs
            if (content != null)
            {
                Songs = content;
            }
            listBoxSongList.Items.Clear();
            listBoxSongList.Items.AddRange(Songs.ToArray());
            listBoxSongList.DisplayMember = "Title";
        }

        /// <summary>
        /// For changing behavior when select index in Listbox 
        /// </summary>
        private void ListBoxSongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Requirement when song is selected there's only edit and delete button also refresh button will stay.
            buttonAdd.Visible = false;
            buttonEdit.Visible = true;
            buttonDelete.Visible = true;


            var selectedItem = listBoxSongList.SelectedItem as Song;
            if (selectedItem == null)
            {
                return;
            }

            //Changing input textbox as same as data song in the listbox
            textBoxTitle.Text = selectedItem.Title;
            textBoxArtist.Text = selectedItem.Artist;
            var currentGenre = Genres.Where(Q => Q.GenreName == selectedItem.GenreName).FirstOrDefault();
            comboBoxGenre.SelectedItem = currentGenre;
            numericUpDownMinutes.Value = selectedItem.Length / 60;
            numericUpDownSeconds.Value = selectedItem.Length % 60;
            dateTimePickerReleaseDate.Value = selectedItem.ReleaseDate.DateTime;
            checkBoxIsAvailable.Checked = selectedItem.IsAvailable;
        }

        /// <summary>
        /// Refresh button method, updating data to server
        /// </summary>
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            labelNotification.Visible = true;
            PopulateListBox();
            ClearBox();
            labelNotification.Text = "Refreshing Song List";
        }

        /// <summary>
        /// Add new song to list, by fill all input. using api
        /// </summary>
        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            //defining fields needed in api
            labelNotification.Visible = true;
            var title = textBoxTitle.Text;
            var artist = textBoxArtist.Text;
            var genre = comboBoxGenre.Text;
            var length = numericUpDownMinutes.Value * 60 + numericUpDownSeconds.Value;
            var releaseDate = dateTimePickerReleaseDate.Value;

            //Validation Input
            if (string.IsNullOrEmpty(title))
            {
                labelNotification.Text = "Title can't be empty";
                return;
            }
            else if (string.IsNullOrEmpty(artist))
            {
                labelNotification.Text = "Artist can't be empty";
                return;
            }
            else if (string.IsNullOrEmpty(genre))
            {
                labelNotification.Text = "Genre can't be empty";
                return;
            }
            else if (genre != "Pop" && genre != "Electronic" && genre != "Rock")
            {
                labelNotification.Text = "Only 3 Genre is available: Pop , Electronic & Rock";
                return;
            }
            else if (numericUpDownSeconds.Value < (decimal)0m && numericUpDownSeconds.Value > (decimal)59m)
            {
                labelNotification.Text = "Input Seconds between 0 - 59";
                return;
            }
            else if (numericUpDownMinutes.Value == (decimal)0m)
            {
                labelNotification.Text = "Please input minutes and seconds correctly";
                return;
            }
            else if (releaseDate > DateMaximal)
            {
                labelNotification.Text = "Release date will be 7 days after today at the latest";
                return;
            }
            else
            {
                labelNotification.Text = "Looks like you good to go";
            }

            var selectedGenre = comboBoxGenre.SelectedItem as Genre;
            if (selectedGenre == null)
            {
                labelNotification.Text = "Genres can't be empty";
                return;
            }

            //make an instance of model to store by api
            var songModel = new SongInput
            {
                SongId = listBoxSongList.Items.Count + 1,
                Title = title,
                Artist = artist,
                GenreId = selectedGenre.GenreId,
                Length = (int)length,
                ReleaseDate = releaseDate,
                IsAvailable = checkBoxIsAvailable.Checked
            };
            var jsonString = JsonConvert.SerializeObject(songModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            //Api calling
            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:10000/api/song", content);
            response.EnsureSuccessStatusCode();

            //Display result, success or failed
            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = $"Successfully to insert Song : {title}";
            }
            else
            {
                labelNotification.Text = "Failed to insert new song";
            }

            //updating listbox as new as added.
            PopulateListBox();
            ClearBox();
        }

        /// <summary>
        /// Edit button method, by fill all input. using api
        /// </summary>   
        private async void ButtonEdit_Click(object sender, EventArgs e)
        {
            //defining fields as needed in api
            labelNotification.Visible = true;
            var selectedSong = listBoxSongList.SelectedItem as Song;
            var title = textBoxTitle.Text;
            var artist = textBoxArtist.Text;
            var genre = comboBoxGenre.SelectedItem as Genre;
            var length = numericUpDownMinutes.Value / 60 + numericUpDownSeconds.Value;
            var releaseDate = dateTimePickerReleaseDate.Value;
            var isAvailable = checkBoxIsAvailable.Checked;


            //Validation input
            if (string.IsNullOrEmpty(title))
            {
                labelNotification.Text = "Title can't be empty";
                return;
            }
            else if (string.IsNullOrEmpty(artist))
            {
                labelNotification.Text = "Artist can't be empty";
                return;
            }
            else if (numericUpDownSeconds.Value < (decimal)0m && numericUpDownSeconds.Value > (decimal)59m)
            {
                labelNotification.Text = "Input Seconds between 0 - 59";
                return;
            }
            else if (numericUpDownMinutes.Value == (decimal)0m && numericUpDownSeconds.Value == (decimal)0m)
            {
                labelNotification.Text = "Please input minutes and seconds correctly";
                return;
            }
            else if (releaseDate > DateMaximal)
            {
                labelNotification.Text = "Release date will be 7 days after today at the latest";
                return;
            }
            else if (genre == null)
            {
                labelNotification.Text = "Please choose a genre above";
                return;
            }
            else if (selectedSong == null)
            {
                //Keknya sih ga mungkin kesini yaa, soalnya tombol edit di hide kalo belom diselect lagunya
                labelNotification.Text = "Please choose a song to edit";
                return;
            }
            else
            {
                labelNotification.Text = "Looks like you good to go";
            }

            //Make instance of a model to stored by api
            var songEdit = new SongInput
            {
                SongId = selectedSong.SongId,
                Title = title,
                Artist = artist,
                GenreId = genre.GenreId,
                Length = (int)length,
                ReleaseDate = releaseDate,
                IsAvailable = isAvailable
            };
            var jsonString = JsonConvert.SerializeObject(songEdit);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            //calling api
            var response = await _httpClient.PutAsync("https://new-dev.accelist.com:10000/api/song", content);
            response.EnsureSuccessStatusCode();

            //display result either success or failed 
            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Success Updating Song";
            }
            else
            {
                labelNotification.Text = "Failed to Update Song";
            }

            //updating listbox as new 
            PopulateListBox();
            ClearBox();
        }

        /// <summary>
        /// delete method, by selected song in the list box. using api
        /// </summary>
        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            labelNotification.Visible = true;

            var selectedSong = listBoxSongList.SelectedItem as Song;

            //Validating if there's no selected song, but its impossible to reach here cause the button is hidden if no song is selected
            if (selectedSong == null)
            {
                labelNotification.Text = "Please Choose a song to be deleted";
                return;
            }

            //called api
            var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:10000/api/song/{selectedSong.SongId}");
            response.EnsureSuccessStatusCode();

            //display result either success or failed
            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Delete Song Successfully";
            }
            else
            {
                labelNotification.Text = "Failed to Delete Song";
            }

            //updating list box
            PopulateListBox();
            ClearBox();
        }

        /// <summary>
        /// Search Method when text changed, works like filtering.
        /// </summary>
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {      
            //ini ada 2 listbox , buat ngumpetin error.
            //jadi yang fitur search bar itu datanya taro di list box 2.. soalnya kalo tetep taro di 1 udah ke binding gitu datanya.. jadi kalo mau refresh atau lakuin hal lain jadi error..
            var searchText = textBoxSearch.Text;
            if(string.IsNullOrEmpty(searchText))
            {
                listBoxSongList2.Visible = false;
                listBoxSongList.Visible = true;
            }
            else
            {
                listBoxSongList.Visible = false;
                listBoxSongList2.Visible = true;
            }
            //using binding source , if don't there's error happen
            var songBinding = new BindingSource();
            var songList = Songs.Where(Q => Q.Title.ToLower().Contains(searchText) || Q.Artist.ToLower().Contains(searchText));
            foreach(var song in songList ) {
                songBinding.Add(song);
            }
            listBoxSongList2.DataSource = songBinding;
            listBoxSongList2.DisplayMember = "Title";

        }
    }
}
