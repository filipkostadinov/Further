using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace Services.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<CompanyViewModel> GetAll();
    }
}
