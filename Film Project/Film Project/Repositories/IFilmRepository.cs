﻿using Film_Project.Models.Domain;
using Film_Project.Models.DTO;

namespace Film_Project.Repositories
{
    public interface IFilmRepository
    {
        List<FilmIdDTO> GetAllFilms(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true);

        Films GetFilmById(int id);

        FilmDTO AddFilm(FilmDTO filmDTO);

        FilmDTO? UpdateFilmById(int id, FilmDTO filmDTO);

        Films? DeleteFilmById(int id);
    }
}