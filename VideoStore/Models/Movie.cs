using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoStore.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer CurrentRentingCustomer { get; set; }

        public List<Customer> PreviousRentingCustomers { get; set; }

        public Movie()
        {
            PreviousRentingCustomers = new List<Customer>();
        }
    }
}