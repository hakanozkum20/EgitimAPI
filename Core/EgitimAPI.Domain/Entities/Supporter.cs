using EgitimAPI.Domain.Entities.Common;

namespace EgitimAPI.Domain.Entities;

public class Supporter : BaseEntity
{
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public long PhoneNumber { get; set; }
    
}