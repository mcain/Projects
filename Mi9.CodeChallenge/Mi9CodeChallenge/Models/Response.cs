#region

using System.Runtime.Serialization;

#endregion

namespace Mi9.CodeChallenge.Models
{
    [DataContract]
    public class Response
    {
        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "image")]
        public string Image { get; set; }
    }
}