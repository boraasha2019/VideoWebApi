namespace VideoPlayer.Handlers.Interface
{
    public interface IRequestHandler<TReq, TResp>
    {
        TResp ProcessRequest(TReq req);
    }
}
