using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MovieTicketReservation.Models;

namespace MovieTicketReservation.Controllers
{
    public class HomeController : Controller
    {
       [Route("")]
       public IActionResult HomePage()
        {
            return View("MainPage");
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult LoginUser()
        {
            return View();
        }
        public IActionResult BookMovie()
        {
            return View();
        }
        public IActionResult SaveUserData(CustomerModel obj)
        {
        //    CustomerModel obj = new CustomerModel();
        //    obj.firstName = Request.Form["firstName"];
        //    obj.lastName = Request.Form["lastName"];
        //    obj.Email = Request.Form["Email"];
        //    obj.Password = Request.Form["Password"];
            return View("MainPage",obj);
        }
    }
}
