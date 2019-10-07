using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool PermissionToLogin { get; set; }
        public CompanyViewModel Company { get; set; }

        public string Username { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
