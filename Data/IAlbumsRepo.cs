using System;
using System.Collections.Generic;
using ExperianAPI.Models;

namespace ExperianAPI.Data
{
    public interface IAlbumsRepo
    {
        #region Read

        /// <summary>
        /// This is method to get all albums 
        /// </summary>
        /// <returns>IEnumerable object of type T where T is Album object</returns>
        IEnumerable<Album> GetAllAlbums();

        /// <summary>
        /// This is method to get all photos
        /// </summary>
        /// <returns>IEnumerable object of type T where T is Photo object</returns>
        IEnumerable<Photo> GetAllPhotos();

        #endregion Read
    }
}
