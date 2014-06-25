#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Mi9.CodeChallenge.Models
{
    [DataContract]
    public class Episode
    {
        [DataMember(Name = "channel")]
        public string Channel { get; set; }

        [DataMember(Name = "channelLogo")]
        public string ChannelLogo { get; set; }

        [DataMember(Name = "date")]
        public DateTime? Date { get; set; }

        [DataMember(Name = "html")]
        public string Html { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }
    }
}