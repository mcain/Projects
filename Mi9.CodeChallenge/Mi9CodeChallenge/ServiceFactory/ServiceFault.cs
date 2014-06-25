#region

using System.Runtime.Serialization;

#endregion

namespace Mi9.CodeChallenge.ServiceFactory
{
    [DataContract]
    public class ServiceFault
    {
        [DataMember(Name = "error")]
        public string Error { get; set; }

        // Note: This property can be used to provide the exception
        // message of the service fault. It's supported in the 
        // "CustomServiceErrorHandler.cs" class where it can be assigned
        // to the Exception.Message in the HttpResponseMessgE

        // [DataMember(Name = "detail")]
        // public string Detail { get; set; }
    }
}