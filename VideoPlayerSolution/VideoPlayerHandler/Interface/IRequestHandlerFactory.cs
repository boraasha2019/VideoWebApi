using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayer.Handlers.Interface
{
    public interface IRequestHandlerFactory
    {
        TResponse ProcessRequest<TRequest, TResponse>(TRequest request);
    }
}
