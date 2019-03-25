using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VideoPlayerApi.Helper;
using VideoPlayerApi.Models;

namespace VideoPlayerApi.Repository.MoviesRepository
{
    public class MoviesRepository : IMoviesRepository
    {

        private List<Movies> listMovies = new List<Movies>();

        public MoviesRepository()
        {
            var folderPath = @"G:\Movies\English";
            var id = 0;
            if (Directory.Exists(folderPath))
            {
                foreach (var movies in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories))
                {
                    if (Utility.IsValidMovieExtension(Path.GetExtension(movies)))
                        listMovies.Add(new Movies { MovieId = ++id, MovieName = Path.GetFileName(movies), MovieLanguage = Path.GetFileName(folderPath) });
                }
            }
        }
        /// <summary>
        /// To fetch the movie with a movie Id
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public Movies GetMovieById(int movieId)
        {
            return listMovies.FirstOrDefault(movie => movie.MovieId == movieId);
        }

        /// <summary>
        /// To fetch all the movies
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Movies> GetMovies()
        {
            return listMovies;
        }
    }
}
