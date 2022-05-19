using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Data;
using MovieApp.Web.Entity;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Controllers
{
    public class UserController : Controller
    {
        public readonly MovieContext _context;
         public UserController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new User
                {
                    Username = model.UserName,
                    Person = new Person { Name=model.Name},
                    Email = model.Email,
                    Password = model.Password,
                    BirthDate = model.BirthDate
                };
                _context.Users.Add(entity);
                _context.SaveChanges();
                
            }
            
            return RedirectToAction("LoginUser");
        }

        public IActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string _userName)
        {

            return View();
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyUserName(string UserName)
        {
            if (_context.Users.Any(i => i.Username == UserName))
            {
                return Json($"zaten {UserName} isimli kullanıcı adı daha önce alınmış.");
            }
            return Json(true);
        }
    }
}
