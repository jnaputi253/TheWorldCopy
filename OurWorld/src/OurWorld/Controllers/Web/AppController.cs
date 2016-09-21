using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Configuration;
using OurWorld.Services;
using OurWorld.ViewModels;

namespace OurWorld.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;

        public AppController(IMailService mailService, IConfigurationRoot config)
        {
            _mailService = mailService;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (model.Email.Contains("aol.com"))
            {
                ModelState.AddModelError("", "Unsupported email format");
            }

            if (!ModelState.IsValid) return View();

            _mailService.SendMail(_config["MailSettings:ToAddress"], model.Email, "From Our World", model.Message);
            ViewBag.UserMessage = "Message Sent";
            ModelState.Clear();

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
