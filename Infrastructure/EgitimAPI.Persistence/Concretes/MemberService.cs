using EgitimAPI.Application.Abstractions;
using EgitimAPI.Domain.Entities;

namespace EgitimAPI.Persistence.Concretes;

public class MemberService : IMemberService
{
    public List<Member> GetMember()
        => new List<Member>()
        {
            new(){Id=Guid.NewGuid(),FirstName = "Hakan", SurName = "Ozkum", Address = "izmit", Email = "hakanozkum@gmail.com", PhoneNumber = 05388188672,},
            new(){Id=Guid.NewGuid(),FirstName = "Ömer", SurName = "Çakar", Address = "izmit", Email = "omer1@gmail.com", PhoneNumber = 05328188671,},
            new(){Id=Guid.NewGuid(),FirstName = "Gülsüm", SecondName = "Nur" ,SurName = "Maslak", Address = "izmit", Email = "gülsüm@gmail.com", PhoneNumber = 05368188671,},
            new(){Id=Guid.NewGuid(),FirstName = "Eminhan", SurName = "Darıcı", Address = "izmit", Email = "eminhan@gmail.com", PhoneNumber = 05328128671,},
            
        };


}