using Microsoft.AspNetCore.Identity;

namespace Film_Project.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}