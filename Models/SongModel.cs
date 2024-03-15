using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamNETIntermediate.Models
{

    // Class SongModel is used as a model for the song object that we can access from the api
    public class SongModel
    {
        //property for songId 
        public int SongId { get; set; }
        //property for title 
        public string Title { get; set;} = string.Empty;
        //property for artist
        public string Artist { get; set; } = string.Empty;
        //property for genreId 
        public int GenreId { get; set; }
        //property for length 
        public int Length { get; set; }
        //property for releaseDate 
        public DateTimeOffset ReleaseDate {  get; set; }
        //property for isAvailable 
        public bool IsAvailable {  get; set; }
    }

    // Class SongModel is used as a model for the genre object that we can access from the api
    public class GenreModel
    { 
        //property for genreId 
        public int GenreId { get;set; }
        //property for genreName
        public string GenreName { get; set; } = string.Empty;
    }

}
