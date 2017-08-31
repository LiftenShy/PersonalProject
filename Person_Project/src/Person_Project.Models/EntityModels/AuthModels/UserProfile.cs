using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Project.Models.EntityModels.AuthModels
{
    public class UserProfile
    {
        public int Id { get; set; }

        public string LoginName { get; set; }

        public byte[] PasswordHash { get; set; }
    }
}
