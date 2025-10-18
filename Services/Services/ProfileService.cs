using StackDynamiProfile.Models;
using StackDynamiProfile.Services.IServices;

namespace StackDynamiProfile.Services.Services
{
    public class ProfileService : IProfileService
    {
        private readonly CatFactService _catFactService;

        public ProfileService(CatFactService catFactService)
        {
            _catFactService = catFactService;
        }

        public async Task<ProfileResponse> GetProfileAsync()
        {
            var catFact = await _catFactService.GetRandomFactAsync();

            var profile = new ProfileResponse
            {
                Status = "success",
                User = new UserInfo
                {
                    Email = "rahmanabdulquadir@example.com",
                    Name = "Abdul-Quadir Rahman Taiwo",
                    Stack = ".NET Developer"
                },
                Timestamp = DateTime.UtcNow.ToString("o"), // ✅ ISO 8601 UTC
                Fact = catFact
            };

            return profile;
        }
    }
}