﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Controllers
{
   [Authorize]
    public class AccountController : Controller
    {

        private readonly MovieContext _context;
       
        public AccountController(MovieContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;

            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public  IActionResult Login(LogInModel model ,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                //var entity = _context.Users.Where(a => a.Username == model.UserName).
                //FirstOrDefault(a => a.Password == model.Password);

                //return Redirect(returnUrl ?? "/");

               
            }
            
            
            
           

            ViewBag.returnUrl = returnUrl;

            return View();
        }
    }
}