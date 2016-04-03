using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using ContactList.Models;
using Swashbuckle.Swagger.Annotations;

namespace ContactList.Controllers
{
    public class VideoGameController : ApiController
    {
        private const string FILENAME = "videogames.json";
        private GenericStorage _storage;

        public VideoGameController()
        {
            _storage = new GenericStorage();
        }

        private async Task<IEnumerable<VideoGame>> GetVideoGames()
        {
            var contacts = await _storage.Get<VideoGame>(FILENAME);

            if (contacts == null)
            {
                await _storage.Save(new VideoGame[]{
                        new VideoGame { Id = 1, Name = "Call of Duty: Modern Warfare", Genre = "Action", Platform = "XBox One"},
                        new VideoGame { Id = 2, Name = "Mega Man", Genre="Adventure", Platform = "Nintendo Entertainment System"},
                        new VideoGame { Id = 3, Name = "FIFA 16", Genre="Sport", Platform = "Xbox One"}
                    }
                , FILENAME);
            }

            return contacts;
        }

        /// <summary>
        /// Gets the list of videogames
        /// </summary>
        /// <returns>The videogames</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(IEnumerable<VideoGame>))]
        [Route("~/videogames")]
        public async Task<IEnumerable<VideoGame>> Get()
        {
            return await GetVideoGames();
        }

        /// <summary>
        /// Gets a specific videogame
        /// </summary>
        /// <param name="id">Identifier for the videogame</param>
        /// <returns>The requested videogame</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "OK",
            Type = typeof(IEnumerable<VideoGame>))]
        [SwaggerResponse(HttpStatusCode.NotFound,
            Description = "Contact not found",
            Type = typeof(IEnumerable<VideoGame>))]
        [SwaggerOperation("GetVideoGameById")]
        [Route("~/videogames/{id}")]
        public async Task<VideoGame> Get([FromUri] int id)
        {
            var videogames = await GetVideoGames();
            return videogames.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Creates a new videogames
        /// </summary>
        /// <param name="videogame">The new videogame</param>
        /// <returns>The saved videogame</returns>
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.Created,
            Description = "Created",
            Type = typeof(VideoGame))]
        [Route("~/videogames")]
        public async Task<VideoGame> Post([FromBody] VideoGame videogame)
        {
            var videogames = await GetVideoGames();
            var videoGameList = videogames.ToList();
            videoGameList.Add(videogame);
            await _storage.Save<VideoGame>(videoGameList, FILENAME);
            return videogame;
        }

        /// <summary>
        /// Deletes a contact
        /// </summary>
        /// <param name="id">Identifier of the contact  to be deleted</param>
        /// <returns>True if the contact was deleted</returns>
        [HttpDelete]
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "OK",
            Type = typeof(bool))]
        [SwaggerResponse(HttpStatusCode.NotFound,
            Description = "Contact not found",
            Type = typeof(bool))]
        [Route("~/videogames/{id}")]
        public async Task<HttpResponseMessage> Delete([FromUri] int id)
        {
            var videogames = await GetVideoGames();
            var videogameList = videogames.ToList();

            if (!videogameList.Any(x => x.Id == id))
            {
                return Request.CreateResponse<bool>(HttpStatusCode.NotFound, false);
            }
            else
            {
                videogameList.RemoveAll(x => x.Id == id);
                await _storage.Save<VideoGame>(videogameList, FILENAME);
                return Request.CreateResponse<bool>(HttpStatusCode.OK, true);
            }
        }
    }
}