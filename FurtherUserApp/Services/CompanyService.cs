using AutoMapper;
using DataAccess.Interfaces;
using Domain.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModels;

namespace Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(IRepository<Company> companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }
        public IEnumerable<CompanyViewModel> GetAll()
        {
            var companies = _companyRepository.GetAll().Select(x => _mapper.Map<CompanyViewModel>(x));
            return companies;
        }
    }
}
