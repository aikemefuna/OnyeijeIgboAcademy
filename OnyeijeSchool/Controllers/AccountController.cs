using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OnyeijeSchool.Models;
using OnyeijeSchool.ViewModel;

namespace OnyeijeSchool.Controllers
{


    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger<AccountController> _logger;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ILogger<AccountController> logger
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
        }



        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {


                    UserName = viewModel.Email,
                    Email = viewModel.Email,


                };
                var result = await _userManager.CreateAsync(user, viewModel.Password);


                if (result.Succeeded)
                {
                    var token = _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var confrimationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);
                    _logger.Log(LogLevel.Warning, confrimationLink);
                    _logger.LogInformation("User created a new account with password.");

                    await _userManager.AddToRoleAsync(user, "Student");
                    ViewBag.Success = "Yes";
                   
                    return View();

                }
                foreach (var error in result.Errors)
                {
                    ViewBag.Success = "No";
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                foreach (var error in result.Errors)
                {
                    ViewBag.Success = "No";
                    ModelState.AddModelError("", error.Description);
                }
            }
            ViewBag.Success = "No";
            return View(viewModel);
        }

        public async Task<bool> SendEmail(string recipientmail, string frommail, string subject, string message)
        {
            bool isSend = false;

            try
            {
                var body = "<p>Email From: {0} </p><p>Message:</p><p>{1}</p>";
                var Message = new MailMessage();
                Message.To.Add(new MailAddress(recipientmail));
                Message.From = new MailAddress(frommail);
                Message.Subject = subject;
                Message.Body = string.Format(body, frommail, message);
                Message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "email",  // replace with valid value
                        Password = "password"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(Message);
                    // Settings.  
                    isSend = true;
                }
            }
            catch (Exception)
            {
                // Info  
                ViewBag.Status = "Problem while sending email, Please check details or contact admin.";
                RedirectToAction("Error", "Manage");

            }

            // info.  
            return isSend;
        }
        [AllowAnonymous]
        public async Task<IActionResult> CreatedUser(string id)
        {
            await Task.Delay(1500);
            var user = await _userManager.FindByIdAsync(id);
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }



        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl)
        {
            LoginViewModel model = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(model);
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel viewModel, string returnUrl)
        {
            viewModel.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                
                var user = await _userManager.FindByEmailAsync(viewModel.Email);
                if (user != null && !user.EmailConfirmed && (await _userManager.CheckPasswordAsync(user, viewModel.Password)))
                {
                    ModelState.AddModelError(string.Empty, "Email not confirmed yet");
                    return View(viewModel);
                }
                var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);
                if (result.Succeeded)
                {

                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {

                        return Redirect(returnUrl);
                    }
                    else
                    {
                        if (await _userManager.IsInRoleAsync(user, "Global Admin"))
                        {
                            return RedirectToAction("AdminDashboard", "Dashboard");
                        }
                        if (await _userManager.IsInRoleAsync(user, "GlobalAdmin"))
                        {
                            return RedirectToAction("AdminDashboard", "Dashboard");
                        }
                        else if (await _userManager.IsInRoleAsync(user, "Student"))
                        {
                            return RedirectToAction("StudentDashboard", "Dashboard");
                        }

                        return RedirectToAction("Index", "HomeAts");
                    }
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(viewModel);
        }

        [AcceptVerbs("Get", "Post")]

        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"email {email} is already in use");
            }
        }






        [AllowAnonymous]
        [HttpPost]
      
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {

            var RedirectUrl = Url.Action("ExternalLoginCallBack", "Account", new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, RedirectUrl);
            return new ChallengeResult(provider, properties);

        }

        [AllowAnonymous]
        public async  Task<IActionResult> ExternalLoginCallBack(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            LoginViewModel model = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider : {remoteError}");
                return View("Login", model);
            }
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ModelState.AddModelError(string.Empty, "Error loading external login information.");
                return View("Login", model);
            }
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            ApplicationUser user = null;

            if (email != null)
            {
                user = await _userManager.FindByEmailAsync(email);
                if (user != null && !user.EmailConfirmed)
                {
                    ModelState.AddModelError(string.Empty, "Email not confirmed yet");
                    return View("Login", model);
                }
            }

            var signInresult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (signInresult.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }

            else
            {
                if (email != null)
                {
                    if (user == null)
                    {
                        user = new ApplicationUser
                        {
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email),

                        };
                        await _userManager.CreateAsync(user);
                        await _userManager.AddToRoleAsync(user, "Student");

                        var token = _userManager.GenerateEmailConfirmationTokenAsync(user);
                        var confrimationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);

                         ViewBag.Success = "Yes";
                    }
                    await _userManager.AddLoginAsync(user, info);
                    await _signInManager.SignInAsync(user, isPersistent:false);
                    return View("StudentDashboard");
                    
                }

                ViewBag.ErrorTitle = $"Email claim not recieved from : {info.LoginProvider}";
                ViewBag.ErrorMessage = $"Please contact support@onyeijeschool.com";
              return View("Error");
            }



        }

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Index", "HomeAts");
            }
            var user = await  _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage($"User with the id{userId} can not be found");
            }

           var result =  await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return View();
            }
            ViewBag.ErrorTitle = "Email cannot be confirmed, contact support";
            return View("Error");
        }

    }
}