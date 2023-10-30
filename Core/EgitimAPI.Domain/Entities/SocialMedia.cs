using EgitimAPI.Domain.Entities.Common;

namespace EgitimAPI.Domain.Entities;

public class SocialMedia : BaseEntity
{
    public string Name { get; set; }
    public string Link { get; set; }
}