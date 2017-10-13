
namespace Person_Project.Models.EntityModels.AuthModels
{
    public class UserRole
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int UserId { get; set; }

        public virtual UserProfile UserProfile { get; set;}

        public virtual Role Role { get; set; }
    }
}
