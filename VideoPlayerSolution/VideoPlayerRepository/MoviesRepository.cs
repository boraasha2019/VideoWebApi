using Microsoft.AspNetCore.Hosting;
using System;
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
        /// <param name="movieName"></param>
        /// <returns></returns>
        public Movies GetMovie(string movieName)
        {
            return GetAllMovies().Find(movie => movie.Name.Contains(movieName));
        }

        /// <summary>
        /// To fetch all the movies
        /// </summary>
        /// <returns></returns>
        public List<Movies> GetMovies()
        {
            return GetAllMovies();
        }

        private List<Movies> GetAllMovies()
        {
           // var folderPath = @"G:\Movies\English";
              var folderPath = @"F:\Study\VideoPlayer\VideoPlayerSolution\VideoPlayerSolution\wwwroot\";
            var id = 0;
            var sb = string.Empty;
            var indx = 0;
            List<Movies> movList = new List<Movies>();
            if (Directory.Exists(folderPath))
            {
                //foreach (var direct in Directory.GetDirectories(folderPath, "*.*", SearchOption.AllDirectories))
                //{
                //foreach (var movies in Directory.GetFiles(direct, "*.*", SearchOption.AllDirectories))
                //{
                foreach (var direct in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories))
                {
                    if (Utility.IsValidMovieExtension(Path.GetExtension(direct)))
                    {
                        indx = direct.LastIndexOf("\\");
                        sb = direct.Substring(indx, (direct.Length - indx)).Remove(0, 1);
                        movList.Add(new Movies { Id = ++id, Name = Path.GetFileName(direct), Format = Path.GetExtension(direct).Substring(1), Language = sb });
                    }
                }
                //    }
                //}
            }
            return movList.OrderBy(m => m.Name).ToList();
        }
    }
}
