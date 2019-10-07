using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Interfaces;
using ViewModels;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userSerivce;
        private readonly ICompanyService _companyService;
        public UserController(IUserService userSerice, ICompanyService companyService)
        {
            _userSerivce = userSerice;
            _companyService = companyService;
        }

        [Authorize(Roles = "admin")]
        public IActionResult Users()
        {
            var users = _userSerivce.GetAll();
            return View(users);
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult LogIn(LoginViewModel model)
        {
            try
            {
            _userSerivce.Login(model);
            return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ErrorViewModel erModel = new ErrorViewModel()
                {
                    Message = ex.Message
                };

                return RedirectToAction("Error", "Home", erModel);
            }
        }

        public IActionResult LogOut()
        {
            _userSerivce.LogOut();
            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "admin")]
        public IActionResult Edit(string id)
        {
            try
            {
                UserViewModel user = _userSerivce.GetById(id);
                EditViewModel editViewModel = new EditViewModel()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PermissionToLogin = user.PermissionToLogin,
                    Companies = new SelectList(_companyService.GetAll(), "Id", "Name")
                };
                return View(editViewModel);
            }
            catch (Exception ex)
            {
                ErrorViewModel erModel = new ErrorViewModel()
                {
                    Message = ex.Message
                };

                return RedirectToAction("Error", "Home", erModel);
            }
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel model)
        {
            try
            {
                _userSerivce.Update(model);
                return RedirectToAction("Users");
            }
            catch (Exception ex)
            {
                ErrorViewModel erModel = new ErrorViewModel()
                {
                    Message = ex.Message
                };

                return RedirectToAction("Error", "Home", erModel);
            }
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel()
            {
                Companies = new SelectList(_companyService.GetAll(), "Id", "Name"),
                Roles = new SelectList(_userSerivce.GetAllRoles(), "Name", "Name")
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            try
            {
                _userSerivce.Register(model);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ErrorViewModel erModel = new ErrorViewModel()
                {
                    Message = ex.Message
                };

                return RedirectToAction("Error", "Home", erModel);
            }
        }
    }
}