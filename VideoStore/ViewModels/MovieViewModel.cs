using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoStore.Models;

namespace VideoStore.ViewModels
{
    public class MovieViewModel
    {
        public List<Movie> Movies { get; set; }

        public MovieViewModel()
        {
            Movies = new List<Movie>();
        }
    }
}