using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamNETIntermediate.Models
{
    /// <summary>
    /// Classses for storing Song information. Different variables are required for GET, POST, and PUT, so there are 3 different classes.
    /// </summary>
    internal class SongModel
    {
        public int SongId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public string GenreName { get; set; } = string.Empty;
        public int Length { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsAvailable { get; set; }

    }

    internal class SongInputModel
    {
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public int GenreId { get; set; }
        public int Length { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsAvailable { get; set; }
    }

    internal class SongEditModel
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
