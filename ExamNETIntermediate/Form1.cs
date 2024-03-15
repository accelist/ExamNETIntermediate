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
        }

        public async void GetDataListBox()
        {
            var response = await httpClient.GetAsync(baseUrl + "/song");
            
        }
    }
}
