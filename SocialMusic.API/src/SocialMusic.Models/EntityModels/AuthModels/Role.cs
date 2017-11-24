using SocialMusic.Models.EntityModels.BaseModels;

namespace SocialMusic.Models.EntityModels.AuthModels
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}
