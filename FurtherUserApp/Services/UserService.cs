using AutoMapper;
using DataAccess.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModels;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserRepository _userRepository;
        private readonly IRepository<Company> _companyRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository,
            IRepository<Company> companyRepository,
            IMapper mapper,
            SignInManager<User> signInManager,
            UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userRepository = userRepository;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public IEnumerable<UserViewModel> GetAll()
        {
            var users = _userRepository.GetAll().Select(x => new UserViewModel()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                PermissionToLogin = x.PermissionToLogin,
                Company = _mapper.Map<CompanyViewModel>(x.Company),
                Username = x.UserName,
                DateOfBirth = x.DateOfBirth
            });

            return users;
        }

        public IEnumerable<RoleViewModel> GetAllRoles()
        {
            var roles = _userRepository.GetAllRoles().Select(x => _mapper.Map<RoleViewModel>(x));
            return roles;
        }

        public UserViewModel GetById(string id)
        {
            User user = _userRepository.GetById(id);
            UserViewModel userModel = new UserViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PermissionToLogin = user.PermissionToLogin,
                Company = _mapper.Map<CompanyViewModel>(user.Company)
            };

            return userModel;
        }

        public UserViewModel GetCurrentUser(string username)
        {
            User user = _userRepository.GetByUsername(username);
            UserViewModel userModel = new UserViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PermissionToLogin = user.PermissionToLogin,
                Company = _mapper.Map<CompanyViewModel>(user.Company)
            };
            return userModel;
        }

        public void Login(LoginViewModel loginModel)
        {
            User user = _userRepository.GetByUsername(loginModel.Username);
            if (user != null && !user.PermissionToLogin)
            {
                throw new Exception("You dont have permission to login");
            }

            var result = _signInManager.PasswordSignInAsync(user, loginModel.Password, false, false).Result;

            if (!result.Succeeded)
            {
                throw new Exception("Username or password is not correct");
            }
        }

        public void LogOut()
        {
            _signInManager.SignOutAsync();
        }

        public void Register(RegisterViewModel model)
        {
            User user = new User()
            {
                UserName = model.Username,
                FirstName = model.FirstName,
                LastName = model.LastName,
                CompanyId = model.CompanyId,
                DateOfBirth = model.DateOfBirth                
            };

            string role = model.RoleName;
            if (role == "admin")
            {
                user.PermissionToLogin = true;
            }

            string password = model.Password;

            var result = _userManager.CreateAsync(user, password);

            if (result.Result.Succeeded)
            {
                var currentUser = _userRepository.GetByUsername(user.UserName);
                var roleResult = _userManager.AddToRoleAsync(user, role).Result;
            }
            else
            {
                throw new Exception($"Register failed! , {result.Result.Errors.First().Description}");
            }
        }

        public void Update(EditViewModel model)
        {
            var user = _userRepository.GetById(model.Id);
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.CompanyId = model.CompanyId;
            user.PermissionToLogin = model.PermissionToLogin;
            _userRepository.Update(user);
        }
    }
}
