#region

using System.Runtime.Serialization;

#endregion

namespace Mi9.CodeChallenge.Models
{
    [DataContract]
    public class Payload
    {
        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "drm")]
        public bool Drm { get; set; }

        [DataMember(Name = "episodeCount")]
        public int? EpisodeCount { get; set; }

        [DataMember(Name = "genre")]
        public string Genre { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }

        [DataMember(Name = "nextEpisode")]
        public Episode NextEpisode { get; set; }

        [DataMember(Name = "primaryColour")]
        public string PrimaryColour { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "tvChannel")]
        public string TvChannel { get; set; }

        [DataMember(Name = "image")]
        public Image Image { get; set; }

        [DataMember(Name = "seasons")]
        public Season[] Seasons { get; set; }
    }
}