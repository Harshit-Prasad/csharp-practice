using social_media_api.Entities;

namespace social_media_api.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
