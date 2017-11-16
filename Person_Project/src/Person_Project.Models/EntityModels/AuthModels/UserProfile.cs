using Person_Project.Models.EntityModels.BaseModels;

namespace Person_Project.Models.EntityModels.AuthModels
{
    public class UserProfile : BaseEntity
    {
        public string LoginName { get; set; }

        public byte[] PasswordHash { get; set; }
    }
}
