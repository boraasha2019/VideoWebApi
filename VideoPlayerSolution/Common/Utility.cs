using System;
using System.Linq;

namespace VideoPlayer.Common
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
