﻿namespace Film_Project.Models.Domain
{
    public class FilmDirectors
    {
        public int FilmId { get; set; }

        public int DirectorId { get; set; }

        public Films? Film { get; set; }

        public Directors? Director { get; set; }
    }
}