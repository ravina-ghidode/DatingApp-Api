using API.Entities;

namespace API.Contracts
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser);
    }
}
