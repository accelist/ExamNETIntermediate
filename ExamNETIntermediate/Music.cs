using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamNETIntermediate.Models
{
    public class MusicModel
    {
        public int songId { get; set; }
        public string title { get; set; } = string.Empty;
        public string artist { get; set; } = string.Empty;
        public string genreName { get; set; } 
        public int length { get; set;}
        public DateTime releaseDate { get; set; }
        public bool isAvailable { get; set; }
    }
    public class GenreModel
    {
        public int genreId { get; set; }
        public string genreName { get; set; } =  string.Empty;
    }

    public class MusicInputModel
    {
        public string title { get; set; } = string.Empty;
        public string artist { get; set; } = string.Empty;
        public int genreId { get; set; }
        public int length { get; set; }
        public DateTime releaseDate { get; set; }
        public bool isAvailable { get; set; }
    }

    public class MusicEditModel
    {
        public int songId { get; set; }
        public string title { get; set; } = string.Empty;
        public string artist { get; set; } = string.Empty;
        public int genreId { get; set; }
        public int length { get; set; }
        public DateTime releaseDate { get; set; }
        public bool isAvailable { get; set; }
    }





}