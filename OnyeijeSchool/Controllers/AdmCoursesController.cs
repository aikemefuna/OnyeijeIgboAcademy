using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnyeijeSchool.DbContexts;
using OnyeijeSchool.Models;

namespace OnyeijeSchool.Controllers
{
    public class AdmCoursesController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly OnyeijeContext _context;

        public AdmCoursesController(UserManager<ApplicationUser> userManager, OnyeijeContext context, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: AdmCourses

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Index()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var authenticatedUserName = httpContext.User.Identity.Name;
            var user = await _userManager.FindByNameAsync(authenticatedUserName);

            ViewBag.Admin = "No";
            if (await _userManager.IsInRoleAsync(user, "GlobalAdmin"))
            {
                ViewBag.Admin = "Yes";

            }

            return View(await _context.AdmCourses.OrderByDescending(m => m.DateCreated).ToListAsync());
        }

        // GET: AdmCourses/Details/5
        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var viewModel = new CourseIndex();

            viewModel.AdmCourses = _context.AdmCourses.Where(m => m.CourseId == id).ToList();
            viewModel.InstructorCourse = _context.InstructorCourse.Where(m => m.CourseId == id).ToList();
            viewModel.AdmModules = _context.AdmModules.Where(m => m.CourseId == id).ToList();
            viewModel.AdmClass = _context.AdmClass.Where(m => m.CourseId == id).ToList();
            viewModel.StCourseEnrollment = _context.StCourseEnrollment.Where(m => m.CourseId == id).ToList();
            //ViewBag.instructor = _context.InstructorCourse.Where(m => m.CourseId == id).FirstOrDefault(m => m.Instructor.FullName);
            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        public IActionResult Courses(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var viewModel = new CourseIndex();

            viewModel.AdmCourses = _context.AdmCourses.Where(m => m.CourseId == id).ToList();
            viewModel.InstructorCourse = _context.InstructorCourse.Where(m => m.CourseId == id).ToList();
            viewModel.AdmModules = _context.AdmModules.Where(m => m.CourseId == id).ToList();
            viewModel.AdmClass = _context.AdmClass.Where(m => m.CourseId == id).ToList();
            viewModel.StCourseEnrollment = _context.StCourseEnrollment.Where(m => m.CourseId == id).ToList();
            viewModel.AdmTopic = _context.AdmTopic.Where(m => m.AdmModules.CourseId == id).ToList();
            //ViewBag.instructor = _context.InstructorCourse.Where(m => m.CourseId == id).FirstOrDefault(m => m.Instructor.FullName);
            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // GET: AdmCourses/Create
        [Authorize(Roles = "GlobalAdmin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdmCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "GlobalAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseId,CourseCode,IsEnabled,CourseTitle,VideoUrl,Description,DateCreated,UserCreated,DateModified,UserModified")] AdmCourses admCourses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admCourses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            await Task.Delay(1500);
            return View(admCourses);
        }

        // GET: AdmCourses/Edit/5
        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admCourses = await _context.AdmCourses.FindAsync(id);
            if (admCourses == null)
            {
                return NotFound();
            }
            return View(admCourses);
        }

        // POST: AdmCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "GlobalAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseId,CourseCode,IsEnabled,CourseTitle,VideoUrl,Description,DateCreated,UserCreated,DateModified,UserModified")] AdmCourses admCourses)
        {
            if (id != admCourses.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admCourses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmCoursesExists(admCourses.CourseId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(admCourses);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admCourses = await _context.AdmCourses
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (admCourses == null)
            {
                return NotFound();
            }

            return View(admCourses);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // POST: AdmCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admCourses = await _context.AdmCourses.FindAsync(id);
            _context.AdmCourses.Remove(admCourses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmCoursesExists(int id)
        {
            return _context.AdmCourses.Any(e => e.CourseId == id);
        }
    }
}
