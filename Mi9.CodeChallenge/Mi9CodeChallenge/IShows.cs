#region

using System.ServiceModel;
using System.ServiceModel.Web;
using Mi9.CodeChallenge.Models;

#endregion

namespace Mi9.CodeChallenge
{
    [ServiceContract]
    public interface IShows
    {
        [WebInvoke(UriTemplate = "/",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        [OperationContract]
        [return: MessageParameter(Name = "response")]
        Response[] ShowsWithDrm(Payload[] payload);
    }
}