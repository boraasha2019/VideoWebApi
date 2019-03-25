using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoPlayerApi.Helper
{
    public static class Utility
    {
        private static readonly string[] validMovieExtension = { ".webm", ".avi", ".flv", ".m4v", " .mkv", ".mp4", ".m4p" };

        /// <summary>
        /// to verify if the moview file extension is valid.
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static bool IsValidMovieExtension(string extension)
        {
            return validMovieExtension.Contains(extension);
        }
    }
}
