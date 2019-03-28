using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayer.Handlers.Interface
{
   public interface IRequestHandler<TReq, TResp>
    {
        TResp CreateRequest(TReq req);
    }
}
