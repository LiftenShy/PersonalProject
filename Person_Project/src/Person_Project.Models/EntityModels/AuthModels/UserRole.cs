using Person_Project.Models.EntityModels.BaseModels;

namespace Person_Project.Models.EntityModels.AuthModels
{
    public class UserRole : BaseEntity
    {
        public int RoleId { get; set; }

        public int UserId { get; set; }

        public virtual UserProfile UserProfile { get; set;}

        public virtual Role Role { get; set; }
    }
}
