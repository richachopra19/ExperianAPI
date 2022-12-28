
using System.Collections.Generic;
using ExperianAPI.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ExperianAPI.ViewModels;
using ExperianAPI.ViewModels.Extensions;

namespace ExperianAPI.Controllers
{
    /// <summary>
    /// This endpoint is responsible for albums or photos data related API requests
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        #region Member variables

        private readonly IAlbumsRepo _repository;

        #endregion Member Variables

        #region Constructors

        /// <summary>
        /// Constructor for the AlbumsController, requires repository
        /// </summary>
        public AlbumsController(IAlbumsRepo repository)
        {
            _repository = repository;
        }

        #endregion Constructors

        //GET api/albums
        [HttpGet]
        public ActionResult<IEnumerable<AlbumViewModel>> GetAllAlbums()
        {
            #region Fetch data

            var albums = _repository.GetAllAlbums();
            if (albums == null)
            {
                return NotFound();
            }
            var photos = _repository.GetAllPhotos();
            if (photos == null)
            {
                return NotFound();
            }

            #endregion  Fetch data

            #region Process

            var albumViewModel = new List<AlbumViewModel>().MapFrom(albums);
            foreach (var model in albumViewModel)
            { 
                var photosByAlbum = photos.Where(x => x.AlbumId == model.Album.Id);
                model.Photos = photosByAlbum.ToList();
            }

            #endregion Process

            return Ok(albumViewModel);
        }

        //GET api/albums/{id}
        [HttpGet]
        [Route("{id}")]
        public ActionResult<AlbumViewModel> GetAlbumById(int id)
        {
            #region Fetch Data

            var albums = _repository.GetAllAlbums();
            if (albums == null)
            {
                return NotFound();
            }
            var photos = _repository.GetAllPhotos();
            if (photos == null)
            {
                return NotFound();
            }

            #endregion Fetch Data

            #region Process

            var albumsbyUserId = albums.Where(x => x.UserId == id);
            var albumViewModel = new List<AlbumViewModel>().MapFrom(albumsbyUserId);
            foreach (var model in albumViewModel)
            {
                var photosByAlbum = photos.Where(x => x.AlbumId == model.Album.Id);
                model.Photos = photosByAlbum.ToList();
            }

            #endregion Process

            return Ok(albumViewModel);
        }
    }
}