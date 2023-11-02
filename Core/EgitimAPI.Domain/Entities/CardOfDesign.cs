using EgitimAPI.Domain.Entities.Common;

namespace EgitimAPI.Domain.Entities;

public class CardOfDesign : BaseEntity
{
    public string Name { get; set; }
    public string Topic { get; set; }
    public string Description { get; set; }
    public Design Design { get; set; }
    
}