#region

using System.Linq;
using System.ServiceModel;
using Mi9.CodeChallenge.Models;

#endregion

namespace Mi9.CodeChallenge
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Shows : IShows
    {
        public Response[] ShowsWithDrm(Payload[] payload)
        {
            return payload.Where(p => p.Drm && (p.EpisodeCount.HasValue && p.EpisodeCount > 0))
                .Select(p => new Response
                {
                    Image = (p.Image == null) ? string.Empty : p.Image.ShowImage,
                    Slug = p.Slug,
                    Title = p.Title
                }).ToArray();
        }
    }
}