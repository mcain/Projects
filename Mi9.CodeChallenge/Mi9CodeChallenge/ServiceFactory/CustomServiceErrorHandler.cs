#region

using System;
using System.Net;
using System.Runtime.Serialization.Json;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

#endregion

namespace Mi9.CodeChallenge.ServiceFactory
{
    public class CustomServiceErrorHandler : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            ServiceFault jsonError = new ServiceFault
            {
                Error = "Could not decode request: JSON parsing failed",
                // Detail = error.Message
            };
           
            fault = Message.CreateMessage(version, "", jsonError, new DataContractJsonSerializer(typeof(ServiceFault)));
            fault.Properties.Add(WebBodyFormatMessageProperty.Name, wbf);

            WebBodyFormatMessageProperty wbf = new WebBodyFormatMessageProperty(WebContentFormat.Json);
            HttpResponseMessageProperty rmp = new HttpResponseMessageProperty
            {
                StatusCode = HttpStatusCode.BadRequest,
                StatusDescription = "Could not decode request: JSON parsing failed"
            };

            rmp.Headers[HttpResponseHeader.ContentType] = "application/json";
            fault.Properties.Add(HttpResponseMessageProperty.Name, rmp);
        }
    }
}
