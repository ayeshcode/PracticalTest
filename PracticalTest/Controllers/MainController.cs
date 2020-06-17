using System;
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

        public IActionResult RegisterNewUser()
        {
            return View();
        }
    }
}