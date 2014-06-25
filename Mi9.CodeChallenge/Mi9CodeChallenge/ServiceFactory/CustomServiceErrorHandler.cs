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
            // Create message
            ServiceFault jsonError = new ServiceFault
            {
                Error = "Could not deserialize json data. Bad request",
                Detail = error.Message
            };
            fault = Message.CreateMessage(version, "", jsonError, new DataContractJsonSerializer(typeof (ServiceFault)));

            // Tell WCF to use JSON encoding rather than default XML
            WebBodyFormatMessageProperty wbf = new WebBodyFormatMessageProperty(WebContentFormat.Json);
            fault.Properties.Add(WebBodyFormatMessageProperty.Name, wbf);

            // Modify response
            HttpResponseMessageProperty rmp = new HttpResponseMessageProperty
            {
                StatusCode = HttpStatusCode.BadRequest,
                StatusDescription = "Bad Request"
            };

            rmp.Headers[HttpResponseHeader.ContentType] = "application/json";
            fault.Properties.Add(HttpResponseMessageProperty.Name, rmp);
        }
    }
}