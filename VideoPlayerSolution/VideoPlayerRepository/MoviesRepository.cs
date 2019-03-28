﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VideoPlayer.Common;
using VideoPlayer.Models;

namespace VideoPlayer.Repository
{
    public class MoviesRepository
    {
        private Lazy<List<Movies>> listMovies = null;

        public MoviesRepository()
        {
            if (listMovies == null)
                listMovies = new Lazy<List<Movies>>(GetAllMovies());
        }
        /// <summary>
        /// To fetch the movie with a movie Id
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public Movies GetMovieById(int movieId)
        {
            return GetAllMovies().FirstOrDefault(movie => movie.MovieId == movieId);
        }

        /// <summary>
        /// To fetch all the movies
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Movies> GetMovies()
        {
            return GetAllMovies();
        }

        private List<Movies> GetAllMovies()
        {
            var folderPath = @"G:\Movies\English";
            var id = 0;
            List<Movies> movList = new List<Movies>();
            if (Directory.Exists(folderPath))
            {
                foreach (var movies in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories))
                {
                    if (Utility.IsValidMovieExtension(Path.GetExtension(movies)))
                        movList.Add(new Movies { MovieId = ++id, MovieName = Path.GetFileName(movies), MovieLanguage = Path.GetFileName(folderPath) });
                }
            }
            return movList;
        }
    }
}
