using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class RegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CompanyId { get; set; }
        public string RoleName { get; set; }

        public SelectList Roles { get; set; }
        public SelectList Companies { get; set; }
    }
}
