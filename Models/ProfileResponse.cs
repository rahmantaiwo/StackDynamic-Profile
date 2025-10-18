namespace StackDynamiProfile.Models
{
    public class ProfileResponse
    {
        public string Status { get; set; } = "succcess";
        public UserInfo User { get; set; } = new();
        public string Timestamp { get; set; } = string.Empty;
        public string Fact { get; set; } = string.Empty;
    }
}
