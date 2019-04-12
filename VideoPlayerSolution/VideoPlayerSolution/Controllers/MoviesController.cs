using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VideoPlayer.Handlers.Interface;
using VideoPlayer.Handlers.Messages;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoPlayerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IRequestHandlerFactory _requestHandlerFactory;

        public MoviesController(IRequestHandlerFactory requestHandlerFactory)
        {
            _requestHandlerFactory = requestHandlerFactory;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult GetMovies()
        {
            return Ok(_requestHandlerFactory.ProcessRequest<MoviesRequest, MoviesResponse>(new MoviesRequest()));
        }

        // GET api/values/5
        [HttpGet("{movieName}")]
        public ActionResult Get(string movieName)
        { 
            MovieRequest request = new MovieRequest();
            request.MovieName = movieName;
            //return Ok(_requestHandlerFactory.ProcessRequest < MovieRequest, MovieResponse)(new MovieRequest());
            return Ok();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


    }
}
