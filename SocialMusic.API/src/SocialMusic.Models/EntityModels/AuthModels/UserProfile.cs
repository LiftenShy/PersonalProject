using SocialMusic.Models.EntityModels.BaseModels;

namespace SocialMusic.Models.EntityModels.AuthModels
{
    public class UserProfile : BaseEntity
    {
        public string LoginName { get; set; }

        public byte[] PasswordHash { get; set; }
    }
}
