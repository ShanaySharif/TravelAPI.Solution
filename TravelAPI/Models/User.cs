namespace TravelAPI
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = string.Empty;
        public byte[] PasswordSalt { get; set; }
    }
}