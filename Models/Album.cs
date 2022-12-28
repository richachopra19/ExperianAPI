
namespace ExperianAPI.Models
{
    /// <summary>
    /// This is a model class for Album object which defines its attributes that actually defines real word attributes as member variables
    /// </summary>
    public class Album
    {
        #region Member Variables

        /// <summary>
        /// int id of album
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of album
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// integer user id
        /// </summary>
        public int UserId { get; set; }

        #endregion Member Variables

    }
}
