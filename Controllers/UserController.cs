using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetCore.Data;
using dotnetCore.Models;
using dotnetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnetCore.Controllers
{
    public class UserController : Controller
    {
        private readonly dotnetCoreContext _context;

        public UserController(dotnetCoreContext context)
        {
            _context = context;
        }

        #region Index
        public IActionResult Index()
        {
            List<User> users = new List<User>();
            //List<LanguageList> languageList = new List<LanguageList>();

            users = _context.User.ToList();
            //languageList = _context.LanguageList.ToList();

            //List<UserViewModel> vmList = new List<UserViewModel>();

            //foreach (User user in users)
            //{
            //    UserViewModel vm = new UserViewModel();

            //    vm.ID = user.ID;
            //    vm.Name = user.Name;

            //    vm.LanguageList = languageList;
            //}

            return View(users);
        }
        #endregion

        #region Create
        // GET: LanguageList/Create
        public IActionResult Create()
        {
            //List<User> users = new List<User>();
            //List<LanguageList> languageList = new List<LanguageList>();

            //users = _context.User.ToList();
            //languageList = _context.LanguageList.ToList();

            //List<UserViewModel> vmList = new List<UserViewModel>();

            //foreach (User user in users)
            //{
            //    UserViewModel vm = new UserViewModel();

            //    vm.ID = user.ID;
            //    vm.Name = user.Name;

            //    vm.LanguageList = languageList;
            //}

            UserViewModel vm = new UserViewModel();
            List<LanguageList> languageList = new List<LanguageList>();

            languageList = _context.LanguageList.ToList();

            vm.LanguageList = languageList;

            return View(vm);
        }
        #endregion
    }
}