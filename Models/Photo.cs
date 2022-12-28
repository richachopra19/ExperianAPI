namespace ExperianAPI.Models
{
    /// <summary>
    /// This is a model class for Photo object which defines its attributes that actually defines real word attributes as member variables
    /// </summary>
    public class Photo
    {
        #region Member Variables

        /// <summary>
        /// Integer id of photo
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of photo
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// integer album id
        /// </summary>
        public int AlbumId { get; set; }

        /// <summary>
        /// url of photo
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// thumnail url of photo
        /// </summary>
        public string ThumbNailUrl { get; set; }

        #endregion Member Variables

    }
}
