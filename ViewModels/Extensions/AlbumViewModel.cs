using ExperianAPI.Models;
using System.Collections.Generic;

namespace ExperianAPI.ViewModels.Extensions
{
    /// <summary>
    /// This class is reponsible for mapping models into my view model for display to the user
    /// </summary>
    public static class AlbumViewModelExtensions
    {
        /// <summary>
        /// This is to map from list of Album object to a list of AlbumViewModel
        /// </summary>
        /// <param name="dest">is a list where T is AlbumViewModel object</param>
        /// <param name="src">is a list where T is Album object</param>
        /// <returns>returns a list of type T where T is AlbumViewModel object</returns>
        public static List<AlbumViewModel> MapFrom(this List<AlbumViewModel> dest, IEnumerable<Album> src)
        {
            #region Bounds Checking

            if (dest == null || src == null)
            {
                return dest;
            }

            #endregion Bounds Checking

            #region Process

            foreach (var x in src)
            {
                dest.Add(new AlbumViewModel().MapFrom(x));
            }

            #endregion Process

            return dest;
        }

        /// <summary>
        /// This is to map from Album object to a AlbumViewModel
        /// </summary>
        /// <param name="dest">is a AlbumViewModel object</param>
        /// <param name="src">is a Album object</param>
        /// <returns>returns a new AlbumViewModel object</returns>
        public static AlbumViewModel MapFrom(this AlbumViewModel dest, Album src)
        {
            #region Bounds Checking

            if (dest == null || src == null)
            {
                return dest;
            }

            #endregion Bounds Checking

            #region Process

            dest.Album.Id = src.Id;
            dest.Album.Title = src.Title;
            dest.Album.UserId = src.UserId;
            

            #endregion Process

            return dest;
        }
    }
}
