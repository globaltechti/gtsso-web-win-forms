namespace GTSSO_WinFormsClient.Models
{
    public class Config
    {
        public string UrlEnrollOtp { get; set; } = "https://gtsso001-dev.globaltechti.com.br:8443/realms/master/account";
        public string UrlToken { get; set; } = "https://gtsso001-dev.globaltechti.com.br:8443/realms/master/protocol/openid-connect/token";
        public string UrlUserExists { get; set; } = "https://gtsso001-dev.globaltechti.com.br:8443/admin/realms/master/users?email=@email";
        public string ClientSecret { get; set; } = "2EU97kLRf6ULgZJi63b3bZokYdqbqPKf";
        public string ClientId { get; set; } = "yamaha";
        public string AdminUser { get; set; } = "ymaha_admin";
        public string AdminPassword { get; set; } = "Yamaha2024#";

    }
}
