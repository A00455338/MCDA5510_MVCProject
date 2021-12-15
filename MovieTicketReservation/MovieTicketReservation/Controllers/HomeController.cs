using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MovieTicketReservation.Models;
using MovieTicketReservation.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Web;

namespace MovieTicketReservation.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieDbContext dbContext;

        public HomeController(MovieDbContext context)
        {
            dbContext = context;
        }
        [Route("")]
        public IActionResult HomePage()
        {
            return View("MainPage");
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult LoginUser(UserModel obj)
        {
            if (ModelState.IsValid) {
                
                var isValidUser = IsValidUser(obj);
                if (isValidUser != null)
                {
                    //FormsAuthentication.SetAuthCookie(obj.Email, false);
                    CustomerModel cust = dbContext.Customer.Where(query => query.email.Equals(obj.email)).SingleOrDefault();
                    ViewData["CustUser"] = cust;
                    return View("MainPage");
                }
                else
                {
                    //If the username and password combination is not present in DB then error message is shown.
                    ModelState.AddModelError("Failure", "Wrong Username and password combination !");
                    return View("LoginUser");
                }
            }
            else
            {
                //If model state is not valid, the model with error message is returned to the View.
                return View(obj);
            }
        }


        //function to check if User is valid or not
        public UserModel IsValidUser(UserModel model)
        {
           
                //Retireving the user details from DB based on username and password enetered by user.
                UserModel user = dbContext.USR.Where(query => query.email.Equals(model.email) && query.password.Equals(model.password)).SingleOrDefault();
            //If user is present, then true is returned.
            if (user == null)
                return null;
            //If user is not present false is returned.
            else
                    return user;
            
        }
    
            public IActionResult BookMovie()
        {
            return View();
        }
        public IActionResult SaveUserData([Bind("firstName,lastName,country,postalcode,phoneNumber,email,password,confirmPassword")] CustomerModel obj)
        {
            UserModel user= new UserModel();
            user.email = obj.email;
            user.password = obj.password;
            if (ModelState.IsValid)
            {
                dbContext.Customer.Add(obj);
                dbContext.SaveChanges();
                dbContext.USR.Add(user);
                dbContext.SaveChanges();
            }
            return View("MainPage",obj);
        }
        [Route("selectSeats")]
        public IActionResult selectSeats()
        {
            return View("Seats");
        }
        [Route("Pay")]
        public IActionResult Pay()
        {
            return View("Payment");
        }
    }
}
