using SocialMusic.Models.EntityModels.AuthModels;

namespace SocialMusic.Authorize.Service.Interfaces
{
    public interface ITokenService
    {
        void Authorize(UserProfile user);
    }
}
