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
    [Route("")]
    public class HomeController : Controller
    {
        private readonly MovieDbContext dbContext;

        public HomeController(MovieDbContext context)
        {
            dbContext = context;
        }
        [Route("")]
        public IActionResult Index()
        {
            List<MoviesModel> movies = (from mov in this.dbContext.Movies
                                        select mov).ToList();

            return View("MainPage",new MoviesList { moviesList = movies });
        }
        [Route("search")]
        public IActionResult Search()
        {
            return View();
        }
        [Route("register")]
        public IActionResult register()
        {
            return View("Register");
        }
        [Route("loginUser")]
        public IActionResult LoginUser(CustomerModel obj)
        {
            if (ModelState.IsValid) {
                var isValidUser = IsValidUser(obj);
                if (isValidUser != null)
                {
                    //FormsAuthentication.SetAuthCookie(obj.Email, false);
                    Console.WriteLine(obj.email);
                    return View("LoginUser",obj);
                }
                else
                {
                    //If the username and password combination is not present in DB then error message is shown.
                    ModelState.AddModelError("Failure", "Wrong Username and password combination !");
                    return View("MainPage");
                }
            }
            else
            {
                //If model state is not valid, the model with error message is returned to the View.
                return View(obj);
            }
        }

        [Route("isValidUser")]
        //function to check if User is valid or not
        public CustomerModel IsValidUser(CustomerModel model)
        {
           
                //Retireving the user details from DB based on username and password enetered by user.
                CustomerModel user = dbContext.Customer.Where(query => query.email.Equals(model.email) && query.password.Equals(model.password)).SingleOrDefault();
            //If user is present, then true is returned.
            if (user == null)
                return null;
            //If user is not present false is returned.
            else
                Console.WriteLine(user.firstName);
                    return user;
            
        }
        [Route("bookMovie")]
        public IActionResult BookMovie(int id)
        {
            //List<CustomerModel> customers = (from customer in this.dbContext.Customer 
            //                            select customer).ToList();

            //return View(new CustList { customers = customers });
            //int i = (int)id;
            List<MoviesModel> movies = (from mov in this.dbContext.Movies 
                                        where mov.movieId == id
                                             select mov).ToList();

            List<TheatreModel> theatre = (from th in this.dbContext.Theatre
                                        select th).ToList();

            List<ShowTimingsModel> time = (from tt in this.dbContext.ShowTimings
                                          select tt).ToList();

            return View(new MoviesList { moviesList = movies });
        }
        [Route("saveUserData")]
        public IActionResult SaveUserData([Bind("firstName,lastName,country,postalcode,phoneNumber,email,password,confirmPassword")] CustomerModel obj)
        {
            
            if (ModelState.IsValid)
            {
                dbContext.Customer.Add(obj);
                dbContext.SaveChanges();
            }
            return View("MainPage",obj);
        }
        [Route("selectSeats")]
        public IActionResult selectSeats(int time)
        {
            return View("Seats");
        }
        [Route("pay")]
        [HttpPost("Pay")]
        public IActionResult Pay(string data)
        {
            Console.WriteLine(data);
            return View("Payment");
        }
    }
}
