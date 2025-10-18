using Microsoft.Extensions.Options;
using StackDynamiProfile.Models;

namespace StackDynamiProfile.Services.Services
{
    public class CatFactService
    {
        private readonly HttpClient _httpClient;
        private readonly CatFactApiSettings _settings;

        public CatFactService(HttpClient httpClient, IOptions<CatFactApiSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings.Value;
            _httpClient.BaseAddress = new Uri(_settings.BaseUrl);
        }

        public async Task<string> GetRandomFactAsync()
        {
            try
            {
                //  Send GET request
                var response = await _httpClient.GetFromJsonAsync<CatFactResponse>("fact");

                //  Return fact text or fallback
                return response?.Fact ?? "No cat fact available right now.";
            }
            catch (Exception ex)
            {
                //  Optional logging or fallback
                return $"Failed to fetch cat fact: {ex.Message}";
            }
        }
    }
}
