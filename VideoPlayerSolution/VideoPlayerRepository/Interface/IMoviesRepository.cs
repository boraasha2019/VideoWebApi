using System;
using System.Collections.Generic;
using System.Text;
using VideoPlayer.Models;

namespace VideoPlayer.Repository.Interface
{
    interface IMoviesRepository
    {
        IEnumerable<Movies> GetMovies();
        Movies GetMovieById(int movieId);
    }
}
