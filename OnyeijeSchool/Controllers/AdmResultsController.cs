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
    public class AdmResultsController : Controller
    {
        private readonly OnyeijeContext _context;

        public AdmResultsController(OnyeijeContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmResults
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdmResult.ToListAsync());
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admResult = await _context.AdmResult
                .FirstOrDefaultAsync(m => m.ResultId == id);
            if (admResult == null)
            {
                return NotFound();
            }

            return View(admResult);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmResults/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdmResults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Create([Bind("ResultId,StudentName,ExamName,Course,TotalQuestions,Attempted,NotAttempted,Correct,InCorrect,Score")] AdmResult admResult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admResult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admResult);
        }

        // GET: AdmResults/Edit/5

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admResult = await _context.AdmResult.FindAsync(id);
            if (admResult == null)
            {
                return NotFound();
            }
            return View(admResult);
        }

        // POST: AdmResults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Edit(int id, [Bind("ResultId,StudentName,ExamName,Course,TotalQuestions,Attempted,NotAttempted,Correct,InCorrect,Score")] AdmResult admResult)
        {
            if (id != admResult.ResultId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admResult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmResultExists(admResult.ResultId))
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
            return View(admResult);
        }

        // GET: AdmResults/Delete/5

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admResult = await _context.AdmResult
                .FirstOrDefaultAsync(m => m.ResultId == id);
            if (admResult == null)
            {
                return NotFound();
            }

            return View(admResult);
        }

        // POST: AdmResults/Delete/5
        [HttpPost, ActionName("Delete")]

        [Authorize(Roles = "GlobalAdmin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admResult = await _context.AdmResult.FindAsync(id);
            _context.AdmResult.Remove(admResult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "GlobalAdmin")]

        private bool AdmResultExists(int id)
        {
            return _context.AdmResult.Any(e => e.ResultId == id);
        }
    }
}
