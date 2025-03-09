using _14bk.Models;
using _14bk.Models;
using _14bk.Services.Email;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _14bk.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
        {
            _logger = logger;
            _emailSender = emailSender;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var emailStatus = _emailSender.SendEmail(new MailBody
            {
                To = "abc@gmail.com",
                Subject = "test email",
                Body = "this is a test email",
            });

            if (emailStatus == MailStatus.Sent)
            {
                ViewBag.Message = "email sent successfully";
            }
            else
            {
                ViewBag.Message = "email sending failed";
            }

            if (_emailSender is SendGridEmailSender sender)
            {
                //var sender = _emailSender as SendGridEmailSender;
                sender.SetSecure();
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}