#region

using System.Runtime.Serialization;

#endregion

namespace Mi9.CodeChallenge.Models
{
    [DataContract]
    public class Image
    {
        [DataMember(Name = "showImage")]
        public string ShowImage { get; set; }
    }
}