using System.Collections.Generic;
using VideoPlayer.Models;

namespace VideoPlayer.Handlers.Messages
{
   public class MoviesResponse
    {
        internal IEnumerable<Movies> MoviesList { get; set; }
    }
}
