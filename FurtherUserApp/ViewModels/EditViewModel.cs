using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class EditViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CompanyId { get; set; }        
        public bool PermissionToLogin { get; set; }

        public SelectList Companies { get; set; }
    }
}
