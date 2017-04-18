using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;
using VideoStore.ViewModels;

namespace VideoStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie dvs www.nissesvideo.se/movie
        public ActionResult Index()
        {
            var movie = new Movie();
            movie.Name = "Starwars";

            var customer = new Customer();
            customer.FirstName = "Kalle";
            customer.LastName = "Olsson";
            movie.CurrentRentingCustomer = customer;

            var movie2 = new Movie();
            movie2.Name = "Starwars - Den nya";

            var customer2 = new Customer();
            customer2.FirstName = "Hans";
            customer2.LastName = "Den andra";
            movie2.CurrentRentingCustomer = customer2;


            movie.PreviousRentingCustomers.Add(customer2);
            movie.PreviousRentingCustomers.Add(customer);

            movie2.PreviousRentingCustomers.Add(customer);
            movie2.PreviousRentingCustomers.Add(customer2);

            var vm = new MovieViewModel();
            vm.Movies.Add(movie);
            vm.Movies.Add(movie2);


            return View(vm);

            #region GÖR INTE SÅHÄR!!

            //Det gamla sättet!
            //ViewData["Movie"] = movie;

            //Det nya sättet!
            //ViewBag.movie = movie;

            #endregion
        }
    }
}