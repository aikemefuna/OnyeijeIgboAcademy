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
    public class AdmClassesController : Controller
    {
        private readonly OnyeijeContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AdmClassesController(OnyeijeContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
      
            _context = context;
          
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: AdmClasses
        public async Task<IActionResult> Index()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var authenticatedUserName = httpContext.User.Identity.Name;
            var user = await _userManager.FindByNameAsync(authenticatedUserName);

            ViewBag.Admin = "No";
            if (await _userManager.IsInRoleAsync(user, "Global Admin"))
            {
                ViewBag.Admin = "Yes";

            }
            var aTSDbContext = _context.AdmClass.Include(a => a.AdmCourses);
            return View(await aTSDbContext.ToListAsync());
        }

        // GET: AdmClasses/Details/5

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admClass = await _context.AdmClass
                .Include(a => a.AdmCourses)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admClass == null)
            {
                return NotFound();
            }

            return View(admClass);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmClasses/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle");
            return View();
        }

        // POST: AdmClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "GlobalAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassName,CourseId,StartDate,EndDate,IsActive,DateCreated,UserCreated,DateModified,UserModified")] AdmClass admClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle", admClass.CourseId);
            return View(admClass);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admClass = await _context.AdmClass.FindAsync(id);
            if (admClass == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle", admClass.CourseId);
            return View(admClass);
        }

        // POST: AdmClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "GlobalAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClassName,CourseId,StartDate,EndDate,IsActive,DateCreated,UserCreated,DateModified,UserModified")] AdmClass admClass)
        {
            if (id != admClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmClassExists(admClass.Id))
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
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle", admClass.CourseId);
            return View(admClass);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admClass = await _context.AdmClass
                .Include(a => a.AdmCourses)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admClass == null)
            {
                return NotFound();
            }

            return View(admClass);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // POST: AdmClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admClass = await _context.AdmClass.FindAsync(id);
            _context.AdmClass.Remove(admClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmClassExists(int id)
        {
            return _context.AdmClass.Any(e => e.Id == id);
        }
    }
}
