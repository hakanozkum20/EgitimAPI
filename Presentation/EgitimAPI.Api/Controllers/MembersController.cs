using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EgitimAPI.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EgitimAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var members = _memberService.GetMember();
            return Ok(members);
        }
    }
}
