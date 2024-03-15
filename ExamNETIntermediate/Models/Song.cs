using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamNETIntermediate.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public string GenreName { get; set; } = string.Empty;
        public TimeSpan Lenght { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsAvailable { get; set; }
    }
    public class Genre
    {
        public int genreId { get; set; }
        public string genreName { get; set; } = string.Empty;
        
    }
    
}
