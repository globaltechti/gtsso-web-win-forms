
using GTSSO_WinFormsClient;
using GTSSO_WinFormsClient.Models;
using GTSSO_WinFormsClient.Models.Responses;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using static System.Net.WebRequestMethods;

namespace GTSSOWinFormsClient.Application
{
    public class SSOApplication
    {

        private readonly Config  _config;

        public SSOApplication()
        {
                this._config = new Config();
        }

        public async Task<User> LoginAsync(string username, string pass, string otp) {

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, this._config.UrlToken);
            var collection = new List<KeyValuePair<string, string>>();
            collection.Add(new("client_id", this._config.ClientId));
            collection.Add(new("client_secret", this._config.ClientSecret));
            collection.Add(new("grant_type", "password"));
            collection.Add(new("username", $"{username}"));
            collection.Add(new("password", $"{pass}"));
            collection.Add(new("otp", $"{otp}"));
            var content = new FormUrlEncodedContent(collection);
            request.Content = content;
            var response = await client.SendAsync(request);

            try
            {
                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                    return new User(true, true, true);
                else
                    return new User(false, false, false);


            }
            catch (Exception ex) {

                return new User(false, false, false);
            }
        }


        public async Task<bool> OtpUserExistsAsync(string email)
        {
            var adminToken = await GetAdminTokenAsync();
            var users = await GetUser(adminToken.AccessToken, email);

            return users.FirstOrDefault( e=> e.Totp) != null;
        }

        private async Task<TokenResponse> GetAdminTokenAsync() {


            var tokenResponse = default(TokenResponse);

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, this._config.UrlToken);
            var collection = new List<KeyValuePair<string, string>>();
            collection.Add(new("client_id", this._config.ClientId));
            collection.Add(new("client_secret", this._config.ClientSecret));
            collection.Add(new("grant_type", "password"));
            collection.Add(new("username", $"{this._config.AdminUser}"));
            collection.Add(new("password", $"{this._config.AdminPassword}"));

            var content = new FormUrlEncodedContent(collection);
            request.Content = content;

            var response = await client.SendAsync(request);


            try
            {
                response.EnsureSuccessStatusCode();

                var responseAsText = await response.Content.ReadAsStringAsync();

                var token = JsonConvert.DeserializeObject<TokenResponse>(responseAsText)
                    ?? new TokenResponse();

                return token;
            }
            catch
            {

                return tokenResponse ?? new TokenResponse(); 
            }

            
        }


        private async Task<IList<UserResponse>> GetUser(string token, string email)
        {
            var users = default(IList<UserResponse>);

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, this._config.UrlUserExists.Replace("@email", email));
            request.Headers.Add("Authorization", "Bearer " + token);
            var response = await client.SendAsync(request);

            try
            {
                response.EnsureSuccessStatusCode();

                var responseAsText = await response.Content.ReadAsStringAsync();

                users =  JsonConvert.DeserializeObject<List<UserResponse>>(responseAsText)
                    ?? new List<UserResponse>();

                return users;
            }
            catch {
                
                return users ?? new List<UserResponse>(); 
            }

        }

        private string GetTokenAsJson(string token)
        {
          
            string secret = "this is a string used for encrypt and decrypt token";
            var key = Encoding.ASCII.GetBytes(secret);
            var handler = new JwtSecurityTokenHandler();
            var validations = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
            var claims = handler.ValidateToken(token, validations, out var tokenSecure);
            
            return claims.Identity.Name;            
        }
    }
}
