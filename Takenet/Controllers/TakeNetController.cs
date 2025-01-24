using Microsoft.AspNetCore.Mvc;
using Takenet.Services;

namespace Takenet.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TakeNetController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetGit([FromServices] IGitHub github)
        {
            var owner = "takenet";
            var userAgent = "request";

            var data = await github.ReturnGitRepository(owner, userAgent);

            var orderedDate = data.OrderBy(repo => repo.created_at).ToList();

            return Ok(new { count= data.Count, data = orderedDate });
        }
    }
}
