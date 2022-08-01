using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SinglePageAppInMVCUsingViewModel.Models
{
    public class AppContext:DbContext
    {
        public AppContext():base("DefaultConnection")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
   
}