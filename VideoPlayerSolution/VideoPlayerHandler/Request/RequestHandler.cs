using System;
using System.Collections.Generic;
using System.Text;
using VideoPlayer.Handlers.Interface;
using VideoPlayer.Handlers.Messages;

namespace VideoPlayer.Handlers.Request
{
    public class RequestHandler : IRequestHandler<TReq, TResp>
    {
        public TResp ProcessRequest(TReq req)
        {
            throw new NotImplementedException();
        }
    }
}
