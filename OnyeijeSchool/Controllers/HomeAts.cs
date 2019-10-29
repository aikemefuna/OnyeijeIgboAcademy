
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnyeijeSchool.DbContexts;
using OnyeijeSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeSchool.Controllers
{
    public class HomeAts : Controller
    {
        private readonly OnyeijeContext _db;

        public HomeAts(OnyeijeContext db)
        {
            _db = db;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Courses()
        {
            var viewModel = new CourseIndex();
            viewModel.AdmCourses = _db.AdmCourses.ToList();
            return View(viewModel);
        }
        public async Task<IActionResult> Instructors()
        {
           var instructor =  await _db.Instructor.OrderByDescending(m => m.DateCreated).ToListAsync();
            ViewBag.instructor = instructor;
            return View(instructor);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

       public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Blog ()
        {
            var viewModel = new CourseIndex();
            viewModel.Blog = _db.Blog.ToList();
            return View(viewModel);
        }

    }
}
