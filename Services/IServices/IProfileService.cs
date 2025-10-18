using StackDynamiProfile.Models;

namespace StackDynamiProfile.Services.IServices
{
    public interface IProfileService
    {
        Task<ProfileResponse> GetProfileAsync();
    }
}
