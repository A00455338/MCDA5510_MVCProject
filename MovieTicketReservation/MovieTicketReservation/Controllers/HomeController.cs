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

        public static string name1;
        public static TimeSpan time1;
        public static string seats;
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
        public IActionResult LoginUser(UserModel obj)
        {
            if (ModelState.IsValid) {
                var isValidUser = IsValidUser(obj);
                if (isValidUser != null)
                {
                    //FormsAuthentication.SetAuthCookie(obj.Email, false);
                    Console.WriteLine(obj.email);
                    return View("LoginUser");
                }
                else
                {
                    //If the username and password combination is not present in DB then error message is shown.
                    ModelState.AddModelError("Failure", "Wrong Username and password combination !");
                    TempData["testmsg"] = "You are not registered,Please Register Here!";
                    return View("Register");
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
        [Route("bookMovie")]
        public IActionResult BookMovie(string name)
        {
            //List<CustomerModel> customers = (from customer in this.dbContext.Customer 
            //                            select customer).ToList();

            //return View(new CustList { customers = customers });
            //int i = (int)id;
            List<MoviesModel> movies = (from mov in this.dbContext.Movies 
                                        where mov.movieName == name
                                             select mov).ToList();

            List<TheatreModel> theatre = (from th in this.dbContext.Theatre
                                        select th).ToList();
            List<ShowTimingsModel> tim = (from ti in this.dbContext.ShowTimings
                                          select ti).ToList();

            List<ShowTimingsModel> time = (from tt in this.dbContext.ShowTimings
                                          select tt).ToList();

            name1 = name;
            return View(new MoviesList { moviesList = movies });
        }
        [Route("saveUserData")]
        public IActionResult SaveUserData([Bind("firstName,lastName,country,postalcode,phoneNumber,email,password,confirmPassword")] CustomerModel obj)
        {
            UserModel user = new UserModel();
            user.email = obj.email;
            user.password = obj.password;
            if (ModelState.IsValid)
            {
                dbContext.Customer.Add(obj);
                dbContext.SaveChanges();
                dbContext.USR.Add(user);
                dbContext.SaveChanges();
            }
            List<MoviesModel> movies = (from mov in this.dbContext.Movies
                                        select mov).ToList();
            return View("MainPage", new MoviesList { moviesList = movies });
        }
        [Route("selectSeats")]
        public ActionResult selectSeats(TimeSpan time)
        {
            time1 = time;
            //string CurrentURL = Request.Url.AbsoluteUri;
            //Console.WriteLine(CurrentURL);
            return View("Seats");
        }
        [Route("Pay")]
        public IActionResult Pay(string data)
        {
            if(data!=null)
            {
                BookingModel bookingModel = new BookingModel();
                bookingModel.movieName = name1;
                bookingModel.timings = time1;
                bookingModel.seatId = data;
                dbContext.Booking.Add(bookingModel);
                dbContext.SaveChanges();
            }
            return View("Payment");
        }
        [Route("paysuccess")]
        public IActionResult BookingDetails()
        {
            List<BookingModel> bmovies = (from book in this.dbContext.Booking
                                        select book).ToList();
            return View("PaySuccess",new BookingList { bookingList = bmovies });
        }
    }
}
