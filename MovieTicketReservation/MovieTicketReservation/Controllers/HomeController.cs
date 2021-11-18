using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
