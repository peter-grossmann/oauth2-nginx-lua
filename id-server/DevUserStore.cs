using System.Security.Claims;
using IdentityModel;

namespace IdServer
{
    public class DevUserStore : IUserStore
    {
        public User ValidateCredentials(string user, string password)
        {
            return new User
            {
                Username = user,
                SubjectId = "Test",
                Claims = new[] {
                    new Claim(JwtClaimTypes.Name, "Test"),
                    new Claim(JwtClaimTypes.GivenName, "Test"),
                    new Claim(JwtClaimTypes.FamilyName, "Test"),
                    new Claim(JwtClaimTypes.Email, "mail@mail.de"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean)
                }
            };
        }
    }
}