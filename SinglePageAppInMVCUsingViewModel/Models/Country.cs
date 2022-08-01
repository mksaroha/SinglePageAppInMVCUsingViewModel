using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinglePageAppInMVCUsingViewModel.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}