using ExperianAPI.Models;
using System.Collections.Generic;

namespace ExperianAPI.ViewModels
{
    /// <summary>
    /// This is view model that holds data of album and photos that we send out as single response
    /// Idea is that each album has its own collection of photos (i.e. photo.albumId == album.Id)
    /// </summary>
    public class AlbumViewModel
    {
        #region Member Variables

        /// <summary>
        /// This is Album object that contains an album data
        /// </summary>
        public Album Album { get; set; }

        /// <summary>
        /// This is collection of photos of type T where T is Photo object that contains a photo obejct
        /// </summary>
        public List<Photo> Photos { get; set; }

        #endregion Member Variables

        #region Constructors

        /// <summary>
        /// make sure we don't get any nulls
        /// </summary>
        public AlbumViewModel()
        {
            Album = new Album();
            Photos = new List<Photo>();
        }

        #endregion Constructors
    }
}
