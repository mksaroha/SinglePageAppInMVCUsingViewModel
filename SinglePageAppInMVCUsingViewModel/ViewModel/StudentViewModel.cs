using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SinglePageAppInMVCUsingViewModel.Models;

namespace SinglePageAppInMVCUsingViewModel.ViewModel
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public List<Student> StudentList { get; set; }       
        public IEnumerable<Country> CountryList { get; set; }
    }
}