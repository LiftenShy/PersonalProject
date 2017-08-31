using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person_Project.Authorize_Service.Models
{
    public class UserProfileModel
    {
        public string LoginName { get; set; }

        public byte[] PasswordHash { get; set; }
    }
}
