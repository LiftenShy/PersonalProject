using SocialMusic.Models.EntityModels.BaseModels;

namespace SocialMusic.Models.EntityModels.AuthModels
{
    public class UserRole : BaseEntity
    {
        public int RoleId { get; set; }

        public int UserId { get; set; }

        public virtual UserProfile UserProfile { get; set;}

        public virtual Role Role { get; set; }
    }
}
