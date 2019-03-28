using VideoPlayer.Handlers.Interface;
using VideoPlayer.Handlers.Messages;
using VideoPlayer.Repository;


namespace VideoPlayer.Handler.Request
{
   public class MoviesRequestHandler : IRequestHandler<MoviesRequest, MoviesResponse>
    {
        public MoviesResponse CreateRequest(MoviesRequest req)
        {
            var response = new MoviesResponse();
            response.MoviesList = new MoviesRepository().GetMovies();
            return response;
        }
    }
}
