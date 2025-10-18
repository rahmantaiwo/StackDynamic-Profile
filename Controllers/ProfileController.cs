using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackDynamiProfile.Services.IServices;

namespace StackDynamiProfile.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet("/me")]
        public async Task<IActionResult> GetProfile()
        {
            var profile = await _profileService.GetProfileAsync();
            return Ok(profile);
        }
    }
}
