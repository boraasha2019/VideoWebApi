using System.Collections.Generic;
using VideoPlayer.Models;

namespace VideoPlayer.Handlers.Messages
{
   public class MoviesResponse
    {
        public List<Movies> MoviesList { get; set; }
    }
}
