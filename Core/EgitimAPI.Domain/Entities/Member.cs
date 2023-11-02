using EgitimAPI.Domain.Entities.Common;

namespace EgitimAPI.Domain.Entities;

public class Member : BaseEntity
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string SurName { get; set; }
    public long TcNo { get; set; }
    public long PhoneNumber { get; set; }
    public string MissionOfMember { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public ICollection<SocialMedia> SocialMedias { get; set; }
    
    // public ICollection<Team> Teams { get; set; }
    public Team Team { get; set; }
    
    
}

