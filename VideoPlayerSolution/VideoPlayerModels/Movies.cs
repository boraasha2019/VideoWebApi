using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoPlayer.Models
{
    public class Movies
    {
        private string _path = @"http:\\localhost:2133\";
        public Movies()
        {
        }
        /// <summary>
        /// stores Move Id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Movie Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// to identify the path of the movie
        /// </summary>
        //  public string MoviePath { get { return _path; } set { _path = value; } }
        public string MoviePath { get { return _path; }  }

        /// <summary>
        /// to identify movie extension
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// MovieDirectory of the movie
        /// </summary>
        public string MovieDirectory { get; set; }
    }
}
