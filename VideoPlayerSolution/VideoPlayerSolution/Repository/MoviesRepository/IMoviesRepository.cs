using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoPlayerApi.Models;

namespace VideoPlayerApi.Repository.MoviesRepository
{
    interface IMoviesRepository
    {
        IEnumerable<Movies> GetMovies();
        Movies GetMovieById(int movieId);
    }
}
