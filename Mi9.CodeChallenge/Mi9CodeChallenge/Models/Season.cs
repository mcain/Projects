#region

using System.Runtime.Serialization;

#endregion

namespace Mi9.CodeChallenge.Models
{
    [DataContract]
    public class Season
    {
        [DataMember(Name = "slug")]
        public string Slug { get; set; }
    }
}