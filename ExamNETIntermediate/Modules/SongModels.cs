using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamNETIntermediate.Modules
{
    // class yang berfungsi untuk menampung data yang diterima dari API Song
    public class SongModels
    {
        public int SongId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public string GenreName { get; set; } = string.Empty;
        public int Length { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsAvailable { get; set; }
    }

    // class yang berfungsi untuk menampung data yang akan dikirim dikarenakan oleh
    // perbedaan requirement antara GenreName dan GenreId
    public class SongModelsPost
    {
        public int SongId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public int GenreId { get; set; }
        public int Length { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsAvailable { get; set; }
    }
}
