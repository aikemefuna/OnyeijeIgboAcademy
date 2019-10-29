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
    public class ExamSetUpsController : Controller
    {
        private readonly OnyeijeContext _context;

        public ExamSetUpsController(OnyeijeContext context)
        {
            _context = context;
        }

        // GET: ExamSetUps
        public async Task<IActionResult> Index()
        {
            var onyeijeContext = _context.ExamSetUp.Include(e => e.AdmClass);
            return View(await onyeijeContext.ToListAsync());
        }

        // GET: ExamSetUps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examSetUp = await _context.ExamSetUp
                .Include(e => e.AdmClass)
                .FirstOrDefaultAsync(m => m.ExaminationId == id);
            if (examSetUp == null)
            {
                return NotFound();
            }

            return View(examSetUp);
        }

        public IActionResult Exam()
        {

            return View();
        }
        // GET: ExamSetUps/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.AdmClass, "Id", "ClassName");
            return View();
        }

        // POST: ExamSetUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExaminationId,Id,IsActive,Title,QuestionNo,Instructions")] ExamSetUp examSetUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(examSetUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.AdmClass, "Id", "ClassName", examSetUp.Id);
            return View(examSetUp);
        }

        // GET: ExamSetUps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examSetUp = await _context.ExamSetUp.FindAsync(id);
            if (examSetUp == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.AdmClass, "Id", "ClassName", examSetUp.Id);
            return View(examSetUp);
        }

        // POST: ExamSetUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExaminationId,Id,IsActive,Title,QuestionNo,Instructions")] ExamSetUp examSetUp)
        {
            if (id != examSetUp.ExaminationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(examSetUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamSetUpExists(examSetUp.ExaminationId))
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
            ViewData["Id"] = new SelectList(_context.AdmClass, "Id", "ClassName", examSetUp.Id);
            return View(examSetUp);
        }

        // GET: ExamSetUps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examSetUp = await _context.ExamSetUp
                .Include(e => e.AdmClass)
                .FirstOrDefaultAsync(m => m.ExaminationId == id);
            if (examSetUp == null)
            {
                return NotFound();
            }

            return View(examSetUp);
        }

        // POST: ExamSetUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var examSetUp = await _context.ExamSetUp.FindAsync(id);
            _context.ExamSetUp.Remove(examSetUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExamSetUpExists(int id)
        {
            return _context.ExamSetUp.Any(e => e.ExaminationId == id);
        }
    }
}
