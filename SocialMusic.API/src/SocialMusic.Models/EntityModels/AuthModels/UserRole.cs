using SocialMusic.Models.EntityModels.BaseModels;
using System.Collections.Generic;

namespace SocialMusic.Models.EntityModels.AuthModels
{
    public class UserRole : BaseEntity
    {
        public int RoleId { get; set; }

        public int UserId { get; set; }

        public virtual List<UserProfile> UserProfiles { get; set;}

        public virtual List<Role> Roles { get; set; }
    }
}
