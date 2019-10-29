using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnyeijeSchool.Models;
using OnyeijeSchool.DbContexts;
using Microsoft.AspNetCore.Authorization;

namespace OnyeijeSchool.Controllers
{
    public class DashboardController : Controller
    {
        private readonly OnyeijeContext _context;

        public DashboardController(OnyeijeContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Global Admin")]
        [Authorize(Policy = "EditRolePolicy")]
        public IActionResult AdminDashboard()
        {
            if (User.Identity.IsAuthenticated)
            {


                var viewModel = new CourseIndex();
                ViewBag.Courses = (from row in _context.AdmCourses select row).Count();
                ViewBag.Modules = (from row in _context.AdmModules select row).Count();
                ViewBag.Topics = (from row in _context.AdmTopic select row).Count();
                ViewBag.Instructors = (from row in _context.Instructor select row).Count();
                ViewBag.Classes = (from row in _context.AdmClass select row).Count();
                viewModel.Blog = _context.Blog.OrderByDescending(m => m.DateCreated).ToList();
                return View(viewModel);
            }
            return RedirectToAction("Login", "Account");
        }

        [Authorize(Roles = "Student")]
        public IActionResult StudentDashboard()
        {
            if (User.Identity.IsAuthenticated)
            {
                var viewModel = new CourseIndex();
                ViewBag.NextClass = (from row in _context.AdmClass where row.StartDate > DateTime.Now.Date select row).Count();
                ViewBag.ActiveClass = (from row in _context.AdmClass where row.StartDate <= DateTime.Now.Date && row.EndDate > DateTime.Now.Date select row).Count();
                ViewBag.PastClasses = (from row in _context.AdmClass where row.StartDate < DateTime.Now.Date && row.EndDate < DateTime.Now.Date select row).Count();
                viewModel.AdmCourses = _context.AdmCourses.ToList();
                viewModel.Blog = _context.Blog.OrderByDescending(m => m.DateCreated).ToList();

                ViewBag.assignment = (from row in _context.AdmAssignment select row).Count();
                ViewBag.exam = (from row in _context.ExamSetUp where row.IsActive == true select row).Count();
                return View(viewModel);
            }
            return RedirectToAction("Login", "Account");
        }


        [HttpGet]
        public IActionResult btnforum_Click(object sender, EventArgs e)
        {

            string username = "admin";
            string email = "alomoge@gmail.com";
            string secretkey = "Qr5prQGpaQ=XADxgEaVSfA$$";

            string hashstring = username + email + secretkey;

            string hash = MD5Hash(hashstring);

            string qstring = "username=" + username + "&email=" + email + "&userHash=" + hash;

            return Redirect("http://localhost/ATSForum/AutoLogin.aspx?" + qstring);
        }
        public static string MD5Hash(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        [HttpGet]
        public IActionResult btnforum_Click2(object sender, EventArgs e)
        {

            string username = "Antho1002";
            string email = "anthony@flexsystemsltd.com";
            string secretkey = "Qr5prQGpaQ=XADxgEaVSfA$$";

            string hashstring = username + email + secretkey;

            string hash = MD5Hash2(hashstring);

            string qstring = "username=" + username + "&email=" + email + "&userHash=" + hash;

            return Redirect("http://localhost:58137/OnlineExam/Module/Student/Instructions.aspx?" + qstring);
        }
        public static string MD5Hash2(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }
    }
}