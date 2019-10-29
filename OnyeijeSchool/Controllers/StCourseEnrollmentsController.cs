using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnyeijeSchool.DbContexts;
using OnyeijeSchool.Models;

namespace OnyeijeSchool.Controllers
{

    [Authorize(Roles = "GlobalAdmin")]
    public class StCourseEnrollmentsController : Controller
    {
        private readonly OnyeijeContext _context;

        public StCourseEnrollmentsController(OnyeijeContext context)
        {
            _context = context;
        }

        // GET: StCourseEnrollments
        public async Task<IActionResult> Index()
        {
            var onyeijeContext = _context.StCourseEnrollment.Include(s => s.AdmCourses).Include(s => s.Student);
            return View(await onyeijeContext.ToListAsync());
        }

        // GET: StCourseEnrollments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stCourseEnrollment = await _context.StCourseEnrollment
                .Include(s => s.AdmCourses)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stCourseEnrollment == null)
            {
                return NotFound();
            }

            return View(stCourseEnrollment);
        }

        // GET: StCourseEnrollments/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseId");
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentFirstName");
            return View();
        }

        // POST: StCourseEnrollments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsApproved,IsCompleted,StudentId,CourseId,ApprovedDate,DateCreated,UserCreated,DateModified,UserModified")] StCourseEnrollment stCourseEnrollment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stCourseEnrollment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseId", stCourseEnrollment.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentFirstName", stCourseEnrollment.StudentId);
            return View(stCourseEnrollment);
        }

        // GET: StCourseEnrollments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stCourseEnrollment = await _context.StCourseEnrollment.FindAsync(id);
            if (stCourseEnrollment == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseId", stCourseEnrollment.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentFirstName", stCourseEnrollment.StudentId);
            return View(stCourseEnrollment);
        }

        // POST: StCourseEnrollments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsApproved,IsCompleted,StudentId,CourseId,ApprovedDate,DateCreated,UserCreated,DateModified,UserModified")] StCourseEnrollment stCourseEnrollment)
        {
            if (id != stCourseEnrollment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stCourseEnrollment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StCourseEnrollmentExists(stCourseEnrollment.Id))
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
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseId", stCourseEnrollment.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "StudentFirstName", stCourseEnrollment.StudentId);
            return View(stCourseEnrollment);
        }

        // GET: StCourseEnrollments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stCourseEnrollment = await _context.StCourseEnrollment
                .Include(s => s.AdmCourses)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stCourseEnrollment == null)
            {
                return NotFound();
            }

            return View(stCourseEnrollment);
        }

        // POST: StCourseEnrollments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stCourseEnrollment = await _context.StCourseEnrollment.FindAsync(id);
            _context.StCourseEnrollment.Remove(stCourseEnrollment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StCourseEnrollmentExists(int id)
        {
            return _context.StCourseEnrollment.Any(e => e.Id == id);
        }
    }
}
