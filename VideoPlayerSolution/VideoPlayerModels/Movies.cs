using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoPlayer.Models
{
    public class Movies
    {
        /// <summary>
        /// stores Move Id
        /// </summary>
        public int MovieId { get; set; }
        
        /// <summary>
        /// Movie Name
        /// </summary>
        public string MovieName { get; set; }

        /// <summary>
        /// to identify the languae of the movie
        /// </summary>
        public string MovieLanguage { get; set; }


    }
}
