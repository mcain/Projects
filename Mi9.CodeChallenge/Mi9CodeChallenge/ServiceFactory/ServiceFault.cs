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

        [DataMember(Name = "detail")]
        public string Detail { get; set; }
    }
}