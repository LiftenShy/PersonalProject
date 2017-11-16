using Person_Project.Models.EntityModels.BaseModels;

namespace Person_Project.Models.EntityModels
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
