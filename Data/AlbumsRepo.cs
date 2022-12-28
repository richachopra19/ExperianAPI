using ExperianAPI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace ExperianAPI.Data
{
    /// <summary>
    /// This class is responsible to call external api endpoint and download all photos and albums in our model object
    /// </summary>
    public class AlbumsRepo : IAlbumsRepo
    {
        #region Member Variables

        private readonly string _url;

        #endregion Member Variables

        #region Constructors

        /// <summary>
        /// empty constructor, which we will default certain things on
        /// </summary>
        public AlbumsRepo() : this("http://jsonplaceholder.typicode.com/")
        {

        }

        /// <summary>
        /// create my class with the objects I need
        /// </summary>
        /// <param name="url">a string url to the page that photos or albums is in</param>
        public AlbumsRepo(string url)
        {
            _url = url;
        }

        #endregion Constructors

        /// <summary>
        /// This is method to get all albums 
        /// </summary>
        /// <returns>IEnumerable object of type T where T is Album object</returns>
        public IEnumerable<Album> GetAllAlbums()
        {
            var client = new System.Net.WebClient
            {
                Encoding = Encoding.UTF8
            };

            #region Fetch Data

            var url = _url + "albums";
            var internalResult = client.DownloadData(url);
            var json = Encoding.UTF8.GetString(internalResult);                                       
            var albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(json);                                                // Deserialize downloaded json into Album object

            #endregion Fetch Data

            return albums;
        }

        /// <summary>
        /// This is method to get all photos
        /// </summary>
        /// <returns>IEnumerable object of type T where T is Photo object</returns>
        public IEnumerable<Photo> GetAllPhotos()
        {
            var client = new System.Net.WebClient
            {
                Encoding = Encoding.UTF8
            };

            #region Fetch Data

            var url = _url + "photos";
            var internalResult = client.DownloadData(url);
            var json = Encoding.UTF8.GetString(internalResult);                                       
            var photos = JsonConvert.DeserializeObject<IEnumerable<Photo>>(json);                                                // Deserialize downloaded json into Photo object

            #endregion Fetch Data

            return photos;
        }

    }
}
