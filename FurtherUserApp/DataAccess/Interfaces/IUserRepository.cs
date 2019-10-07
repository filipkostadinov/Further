using Domain.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IUserRepository
    {
        User GetById(string id);
        User GetByUsername(string username);
        IEnumerable<User> GetAll();
        IEnumerable<IdentityRole> GetAllRoles();
        void Update(User user);
    }
}
