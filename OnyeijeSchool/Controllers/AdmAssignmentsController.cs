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
    public class AdmAssignmentsController : Controller
    {
        private readonly OnyeijeContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AdmAssignmentsController(OnyeijeContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: AdmAssignments
        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {


                var aTSDbContext = _context.AdmAssignment.Include(a => a.AdmClass);
                return View(await aTSDbContext.ToListAsync());
            }
            return RedirectToAction("Login", "Account");
        }

        // GET: AdmAssignments/Details/5

        public async Task<IActionResult> Details(int? id)
        {
            if (User.Identity.IsAuthenticated)
            {


                var httpContext = _httpContextAccessor.HttpContext;
                var authenticatedUserName = httpContext.User.Identity.Name;
                var user = await _userManager.FindByNameAsync(authenticatedUserName);


                if (id == null)
                {
                    return NotFound();
                }

                var admAssignment = await _context.AdmAssignment
                    .Include(a => a.AdmClass)
                    .FirstOrDefaultAsync(m => m.AssignmentId == id);

                ViewBag.Admin = "No";
                if (await _userManager.IsInRoleAsync(user, "GlobalAdmin"))
                {
                    ViewBag.Admin = "Yes";

                }

                if (admAssignment == null)
                {
                    return NotFound();
                }

                return View(admAssignment);
            }
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Assignments()
        {
            if (User.Identity.IsAuthenticated)
            {


                var aTSDbContext = _context.AdmAssignment.Include(a => a.AdmClass);
                return View(aTSDbContext.ToList());
            }
            return RedirectToAction("Login", "Account");
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmAssignments/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.AdmClass, "Id", "ClassName");
            return View();
        }

        [Authorize(Roles = "GlobalAdmin")]
        // POST: AdmAssignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssignmentId,Description,IsEnabled,Title,Id,DateCreated,UserCreated,DateModified,UserModified")] AdmAssignment admAssignment)
        {
            if (User.Identity.IsAuthenticated)
            {


                if (ModelState.IsValid)
                {
                    _context.Add(admAssignment);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ViewData["Id"] = new SelectList(_context.AdmClass, "Id", "ClassName", admAssignment.Id);
                return View(admAssignment);
            }
            return RedirectToAction("Login", "Account");
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmAssignments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admAssignment = await _context.AdmAssignment.FindAsync(id);
            if (admAssignment == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.AdmClass, "Id", "ClassName", admAssignment.Id);
            return View(admAssignment);
        }

        // POST: AdmAssignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "GlobalAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssignmentId,Description,IsEnabled,Title,Id,DateCreated,UserCreated,DateModified,UserModified")] AdmAssignment admAssignment)
        {
            if (id != admAssignment.AssignmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admAssignment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmAssignmentExists(admAssignment.AssignmentId))
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
            ViewData["Id"] = new SelectList(_context.AdmClass, "Id", "ClassName", admAssignment.Id);
            return View(admAssignment);
        }

        // GET: AdmAssignments/Delete/5
        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admAssignment = await _context.AdmAssignment
                .Include(a => a.AdmClass)
                .FirstOrDefaultAsync(m => m.AssignmentId == id);
            if (admAssignment == null)
            {
                return NotFound();
            }

            return View(admAssignment);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // POST: AdmAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admAssignment = await _context.AdmAssignment.FindAsync(id);
            _context.AdmAssignment.Remove(admAssignment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmAssignmentExists(int id)
        {
            return _context.AdmAssignment.Any(e => e.AssignmentId == id);
        }
    }
}
