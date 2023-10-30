using EgitimAPI.Domain.Entities.Common;

namespace EgitimAPI.Domain.Entities;

public class Team : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Design> Designs { get; set; }
}