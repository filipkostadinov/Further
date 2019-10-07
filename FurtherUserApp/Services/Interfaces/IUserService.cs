using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace Services.Interfaces
{
    public interface IUserService
    {
        void Login(LoginViewModel loginModel);
        void Register(RegisterViewModel model);
        void LogOut();
        UserViewModel GetCurrentUser(string username);
        IEnumerable<UserViewModel> GetAll();
        IEnumerable<RoleViewModel> GetAllRoles();
        UserViewModel GetById(string id);
        void Update(EditViewModel model);
    }
}
