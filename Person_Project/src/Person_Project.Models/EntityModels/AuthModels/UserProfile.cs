using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Project.Data.Models.AuthModels
{
    class UserProfile
    {
        public string LoginName { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
