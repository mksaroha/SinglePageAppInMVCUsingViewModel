using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SinglePageAppInMVCUsingViewModel.Models;
using SinglePageAppInMVCUsingViewModel.ViewModel;

namespace SinglePageAppInMVCUsingViewModel.Controllers
{
    public class StudentController : Controller
    {
        AppContext _context = new AppContext();
        // GET: Student
        public ActionResult Index()
        {
            var viewModel = new StudentViewModel
            {
                //Student=_context.Students.ToList()
                StudentList = _context.Students.Include(x=>x.Country).ToList(),  
                CountryList=_context.Countries.ToList()                
            };          
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            if(ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}