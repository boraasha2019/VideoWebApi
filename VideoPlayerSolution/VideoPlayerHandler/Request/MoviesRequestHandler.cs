using VideoPlayer.Handlers.Interface;
using VideoPlayer.Handlers.Messages;
using VideoPlayer.Repository;

namespace VideoPlayer.Handlers.Request
{
   public class MoviesRequestHandler : IRequestHandler<MoviesRequest, MoviesResponse>
    {
        public MoviesResponse ProcessRequest(MoviesRequest req)
        {
            var response = new MoviesResponse();
            response.MoviesList = new MoviesRepository().GetMovies();
            return response;
        }
    }
}
