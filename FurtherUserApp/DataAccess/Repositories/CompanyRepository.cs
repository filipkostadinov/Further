using DataAccess.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class CompanyRepository : IRepository<Company>
    {
        private readonly FurtherDbContext _dbContext;
        public CompanyRepository(FurtherDbContext context)
        {
            _dbContext = context;
        }

        public IEnumerable<Company> GetAll()
        {
            return _dbContext.Companies;
        }

        public Company GetById(int id)
        {
            return _dbContext.Companies.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(Company entity)
        {
            _dbContext.Companies.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Company entity)
        {
            _dbContext.Companies.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Company company = _dbContext.Companies.SingleOrDefault(x => x.Id == id);

            if (company != null)
            {
                _dbContext.Companies.Remove(company);
                _dbContext.SaveChanges();
            }
        }
    }
}
