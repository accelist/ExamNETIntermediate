﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamNETIntermediate.Model
{
    public class SongModelInput
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
