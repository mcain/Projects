#region

using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;

#endregion

namespace Mi9.CodeChallenge.ServiceFactory
{
    public class CustomServiceFactory : WebServiceHostFactory
    {
        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {
            ServiceHost host = base.CreateServiceHost(typeof(Shows), baseAddresses);
            host.AddServiceEndpoint(typeof(IShows), new WebHttpBinding(), string.Empty);
            host.Description
                .Endpoints
                .ToList()
                .ForEach(ep => ep.Behaviors.Add(new CustomEndpointErrorBhaviour()));

            return host;
        }

        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return base.CreateServiceHost(serviceType, baseAddresses);
        }
    }
}