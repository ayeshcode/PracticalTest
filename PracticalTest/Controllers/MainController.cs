﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticalTest.Models;

namespace PracticalTest.Controllers
{
    public class MainController : Controller

    {
        SMSContext ORM = null;
        public MainController(SMSContext _ORM)
        {
            ORM = _ORM;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult RegisterNewUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterNewUser(SystemUsers U)

        {
            try
            {
                U.Role = "Staff";
                U.Status = "Active";
                ORM.SystemUsers.Add(U);
                ORM.SaveChanges();
                ViewBag.Message = "User " + U.UserName + "Registratered Successfully.";
            }
            catch
            {
                ViewBag.Message = "Unable to save new user";
            }

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Login(SystemUsers U)

        {
            SystemUsers LoggedInUser =  ORM.SystemUsers.Where(x=>x.UserName == U.UserName && x.Password == U.Password).FirstOrDefault();
            return View();
        }
    }
}