using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnyeijeSchool.DbContexts;
using OnyeijeSchool.Models;

namespace OnyeijeSchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly OnyeijeContext _context;

        public HomeController(UserManager<ApplicationUser> userManager, OnyeijeContext context, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Protected()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var authenticatedUserName = httpContext.User.Identity.Name;
            var user = await _userManager.FindByNameAsync(authenticatedUserName);

            ViewBag.Admin = "No";
            if (await _userManager.IsInRoleAsync(user, "GlobalAdmin"))
            {
                ViewBag.Admin = "Yes";

            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
