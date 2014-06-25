#region

using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

#endregion

namespace Mi9.CodeChallenge.ServiceFactory
{
    public class CustomEndpointErrorBhaviour : WebHttpBehavior
    {
        protected override void AddServerErrorHandlers(ServiceEndpoint endpoint, EndpointDispatcher epd)
        {
            epd.ChannelDispatcher.ErrorHandlers.Clear();
            epd.ChannelDispatcher.ErrorHandlers.Add(new CustomServiceErrorHandler());
        }
    }
}