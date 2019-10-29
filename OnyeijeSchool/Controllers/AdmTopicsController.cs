using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http.Headers;
using OnyeijeSchool.DbContexts;
using OnyeijeSchool.Models;
using Microsoft.AspNetCore.Authorization;

namespace OnyeijeSchool.Controllers
{
    public class AdmTopicsController : Controller
    {
        private readonly OnyeijeContext _context;
        private IHostingEnvironment _hostingEnvironment;
        public AdmTopicsController(OnyeijeContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmTopics
        public async Task<IActionResult> Index()
        {
            var aTSDbContext = _context.AdmTopic.Include(a => a.AdmModules);
            return View(await aTSDbContext.ToListAsync());
        }

        public async Task<IActionResult> _List()
        {
            var aTSDbContext = _context.AdmTopic.Include(a => a.AdmModules);
            return View(await aTSDbContext.ToListAsync());
        }

        [Authorize(Roles = "GlobalAdmin")]

        // GET: AdmTopics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admTopic = await _context.AdmTopic
                .Include(a => a.AdmModules)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admTopic == null)
            {
                return NotFound();
            }

            return View(admTopic);
        }

        [Authorize(Roles = "GlobalAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int id, [Bind("Id,IsEnabled,TopicNumber,Notes,ModuleId,Summary,Title,DateCreated,UserCreated,DateModified,UserModified,VideoUrl")] AdmTopic admTopic, List<IFormFile> files)
        {
            if (id != admTopic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (files != null && files.Count > 0)
                    {
                        string folderName = "Upload";
                        string webRootPath = _hostingEnvironment.WebRootPath;
                        string newPath = Path.Combine(webRootPath, folderName);
                        if (!Directory.Exists(newPath))
                        {
                            Directory.CreateDirectory(newPath);
                        }
                        foreach (IFormFile item in files)
                        {
                            if (item.Length > 0)
                            {
                                string fileName = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                                string fullPath = Path.Combine(newPath, fileName);
                                using (var stream = new FileStream(fullPath, FileMode.Create))
                                {
                                    item.CopyTo(stream);
                                }
                            }
                        }

                        _context.Update(admTopic);
                        await _context.SaveChangesAsync();
                        return this.Content("Success");
               
                    }
                    return this.Content("Fail");

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmTopicExists(admTopic.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                       
                    }
                }
            }
            ViewData["ModuleId"] = new SelectList(_context.AdmModules, "ModuleId", "Title", admTopic.ModuleId);
            return View(admTopic);
        }

        [Authorize(Roles = "GlobalAdmin")]
        // GET: AdmTopics/Create
        public IActionResult Create()
        {
            ViewData["ModuleId"] = new SelectList(_context.AdmModules, "ModuleId", "Title");
            return View();
        }

        // POST: AdmTopics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsEnabled,TopicNumber,Notes,ModuleId,Summary,Title,DateCreated,UserCreated,DateModified,UserModified,VideoUrl")] AdmTopic admTopic)
        {
            if (ModelState.IsValid)
            {
                //List<TopicFiles> fileDetails = new List<TopicFiles>();
                //for (int i = 0; i < Request.Files.Count; i++)
                //{
                //    var file = Request.Files[i];

                //    if (file != null && file.ContentLength > 0)
                //    {
                //        var fileName = Path.GetFileName(file.FileName);
                //        TopicFiles fileDetail = new TopicFiles()
                //        {
                //            FileName = fileName,
                //            Extension = Path.GetExtension(fileName),
                //            Id = Guid.NewGuid()
                //        };
                //        fileDetails.Add(fileDetail);

                //        var path = Path.Combine(Server.MapPath("~/App_Data/Upload/"), fileDetail.Id + fileDetail.Extension);
                //        file.SaveAs(path);
                //    }
                //}

                //admTopic.TopicFiles = fileDetails;

                _context.Add(admTopic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ModuleId"] = new SelectList(_context.AdmModules, "ModuleId", "Title", admTopic.ModuleId);
            return View(admTopic);
        }

        // GET: AdmTopics/Edit/5

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admTopic = await _context.AdmTopic.FindAsync(id);
            if (admTopic == null)
            {
                return NotFound();
            }
            ViewData["ModuleId"] = new SelectList(_context.AdmModules, "ModuleId", "Title", admTopic.ModuleId);
            return View(admTopic);
        }

        // POST: AdmTopics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsEnabled,TopicNumber,Notes,ModuleId,Summary,Title,DateCreated,UserCreated,DateModified,UserModified,VideoUrl")] AdmTopic admTopic)
        {
            if (id != admTopic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admTopic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmTopicExists(admTopic.Id))
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
            ViewData["ModuleId"] = new SelectList(_context.AdmModules, "ModuleId", "Title", admTopic.ModuleId);
            return View(admTopic);
        }

        // GET: AdmTopics/Delete/5

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admTopic = await _context.AdmTopic
                .Include(a => a.AdmModules)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admTopic == null)
            {
                return NotFound();
            }

            return View(admTopic);
        }

        // POST: AdmTopics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        [Authorize(Roles = "GlobalAdmin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admTopic = await _context.AdmTopic.FindAsync(id);
            _context.AdmTopic.Remove(admTopic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmTopicExists(int id)
        {
            return _context.AdmTopic.Any(e => e.Id == id);
        }
    }
}
