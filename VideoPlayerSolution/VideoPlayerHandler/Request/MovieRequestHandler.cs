using VideoPlayer.Handlers.Interface;
using VideoPlayer.Handlers.Messages;
using VideoPlayer.Repository;

namespace VideoPlayer.Handlers.Request
{
    public class MovieRequestHandler : IRequestHandler<MovieRequest, MovieResponse>
    {
        public MovieResponse ProcessRequest(MovieRequest req)
        {
            var response = new MovieResponse();
            response.Movie = new MoviesRepository().GetMovie(req.MovieName);
            return response;
        }
    }
}
