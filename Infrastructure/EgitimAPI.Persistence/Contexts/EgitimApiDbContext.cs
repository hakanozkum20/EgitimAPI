using EgitimAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EgitimAPI.Persistence.Contexts;

public class EgitimApiDbContext : DbContext
{
    public EgitimApiDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Member> Members { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Design> Designs { get; set; }
    public DbSet<Supporter> Supporters { get; set; }
    public DbSet<CardOfDesign> CardOfDesigns { get; set; }
}