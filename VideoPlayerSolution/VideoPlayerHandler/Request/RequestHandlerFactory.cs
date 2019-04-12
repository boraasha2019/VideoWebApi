using System;
using System.Collections.Generic;
using System.Text;
using VideoPlayer.Handlers.Interface;

namespace VideoPlayer.Handlers.Request
{
    public class RequestHandlerFactory : IRequestHandlerFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public RequestHandlerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public TResponse ProcessRequest<TRequest, TResponse>(TRequest request)
        {
            var handler = (IRequestHandler<TRequest, TResponse>)_serviceProvider.GetService(typeof(IRequestHandler<TRequest, TResponse>));

            if (handler == null)
                throw new NotImplementedException("No Handler Registered for type: " + typeof(TRequest).FullName);
            return handler.ProcessRequest(request);
        }
    }
}
