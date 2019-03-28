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
        private MoviesResponse moviesResponse = new MoviesResponse();

        public MoviesController(IRequestHandlerFactory requestHandlerFactory)
        {
            _requestHandlerFactory = requestHandlerFactory;
        }
        // GET: api/values
        [HttpGet]
        public MoviesResponse GetAllMovies()
        {
            return _requestHandlerFactory.ProcessRequest<MoviesRequest, MoviesResponse>(new MoviesRequest());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public MoviesResponse Get(int id)
        {
            //return moviesRepository.GetMovieById(id);
            var moviesRequest = new MoviesRequest();
            return _requestHandlerFactory.ProcessRequest<MoviesRequest, MoviesResponse>(moviesRequest);
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
