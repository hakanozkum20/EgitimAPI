using EgitimAPI.Domain.Entities;

namespace EgitimAPI.Application.Abstractions;

public interface IMemberService
{
    List<Member> GetMember();
}