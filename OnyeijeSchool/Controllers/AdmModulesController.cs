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
    public class AdmModulesController : Controller
    {
        private readonly OnyeijeContext _context;

        public AdmModulesController(OnyeijeContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Index()
        {
            var aTSDbContext = _context.AdmModules.Include(a => a.AdmCourses);
            return View(await aTSDbContext.ToListAsync());
        }
        public async Task<IActionResult> _List()
        {
            var aTSDbContext = _context.AdmModules.Include(a => a.AdmCourses);
            return View(await aTSDbContext.ToListAsync());
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmModules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admModules = await _context.AdmModules
                .Include(a => a.AdmCourses)
                .FirstOrDefaultAsync(m => m.ModuleId == id);
            if (admModules == null)
            {
                return NotFound();
            }

            return View(admModules);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmModules/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle");
            return View();
        }

        // POST: AdmModules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "GlobalAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ModuleId,Description,IsEnabled,CourseId,ModuleCode,Title,DateCreated,UserCreated,DateModified,UserModified")] AdmModules admModules)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admModules);
                await _context.SaveChangesAsync();
                await Task.Delay(1500);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle", admModules.CourseId);
            return View(admModules);
        }

        // GET: AdmModules/Edit/5
        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admModules = await _context.AdmModules.FindAsync(id);
            if (admModules == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle", admModules.CourseId);
            return View(admModules);
        }

        // POST: AdmModules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "GlobalAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ModuleId,Description,IsEnabled,CourseId,ModuleCode,Title,DateCreated,UserCreated,DateModified,UserModified")] AdmModules admModules)
        {
            if (id != admModules.ModuleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admModules);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmModulesExists(admModules.ModuleId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                await Task.Delay(1500);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.AdmCourses, "CourseId", "CourseTitle", admModules.CourseId);
            return View(admModules);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmModules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admModules = await _context.AdmModules
                .Include(a => a.AdmCourses)
                .FirstOrDefaultAsync(m => m.ModuleId == id);
            if (admModules == null)
            {
                return NotFound();
            }

            return View(admModules);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // POST: AdmModules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admModules = await _context.AdmModules.FindAsync(id);
            _context.AdmModules.Remove(admModules);
            await _context.SaveChangesAsync();
            await Task.Delay(1500);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "GlobalAdmin")]
        private bool AdmModulesExists(int id)
        {
            return _context.AdmModules.Any(e => e.ModuleId == id);
        }
    }
}
