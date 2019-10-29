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
    public class InstructorCoursesController : Controller
    {
        private readonly OnyeijeContext _context;

        public InstructorCoursesController(OnyeijeContext context)
        {
            _context = context;
        }

        // GET: InstructorCourses
        public async Task<IActionResult> Index()
        {
            var aTSDbContext = _context.InstructorCourse.Include(i => i.AdmCourses).Include(i => i.Instructor);
            return View(await aTSDbContext.ToListAsync());
        }

        // GET: InstructorCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructorCourse = await _context.InstructorCourse
                .Include(i => i.AdmCourses)
                .Include(i => i.Instructor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (instructorCourse == null)
            {
                return NotFound();
            }

            return View(instructorCourse);
        }

        // GET: InstructorCourses/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle");
            ViewData["InstructorId"] = new SelectList(_context.Instructor, "InstructorId", "FullName");
            return View();
        }

        // POST: InstructorCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InstructorId,CourseId,DateCreated,UserCreated,DateModified,UserModified")] InstructorCourse instructorCourse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instructorCourse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle", instructorCourse.CourseId);
            ViewData["InstructorId"] = new SelectList(_context.Instructor, "InstructorId", "FullName", instructorCourse.InstructorId);
            return View(instructorCourse);
        }

        // GET: InstructorCourses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructorCourse = await _context.InstructorCourse.FindAsync(id);
            if (instructorCourse == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle", instructorCourse.CourseId);
            ViewData["InstructorId"] = new SelectList(_context.Instructor, "InstructorId", "FullName", instructorCourse.InstructorId);
            return View(instructorCourse);
        }

        // POST: InstructorCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InstructorId,CourseId,DateCreated,UserCreated,DateModified,UserModified")] InstructorCourse instructorCourse)
        {
            if (id != instructorCourse.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instructorCourse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstructorCourseExists(instructorCourse.Id))
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
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle", instructorCourse.CourseId);
            ViewData["InstructorId"] = new SelectList(_context.Instructor, "InstructorId", "FullName", instructorCourse.InstructorId);
            return View(instructorCourse);
        }

        // GET: InstructorCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructorCourse = await _context.InstructorCourse
                .Include(i => i.AdmCourses)
                .Include(i => i.Instructor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (instructorCourse == null)
            {
                return NotFound();
            }

            return View(instructorCourse);
        }

        // POST: InstructorCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instructorCourse = await _context.InstructorCourse.FindAsync(id);
            _context.InstructorCourse.Remove(instructorCourse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstructorCourseExists(int id)
        {
            return _context.InstructorCourse.Any(e => e.Id == id);
        }
    }
}
