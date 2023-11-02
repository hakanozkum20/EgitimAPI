using EgitimAPI.Domain.Entities.Common;

namespace EgitimAPI.Domain.Entities;

public class Design : BaseEntity
{
    public string Name { get; set; }
    public ICollection<CardOfDesign> CardOfDesigns { get; set; }
    
}