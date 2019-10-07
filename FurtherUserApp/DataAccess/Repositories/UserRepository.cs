using DataAccess.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FurtherDbContext _dbContext;
        public UserRepository(FurtherDbContext context)
        {
            _dbContext = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users.Include(x => x.Company);
        }

        public User GetById(string id)
        {
            return _dbContext.Users.SingleOrDefault(x => x.Id == id);
        }

        public User GetByUsername(string username)
        {
            return _dbContext.Users.SingleOrDefault(x => x.UserName == username);
        }

        public void Update(User entity)
        {
            _dbContext.Users.Update(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<IdentityRole> GetAllRoles()
        {
            return _dbContext.Roles;
        }
    }
}
