using DIController.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DIController.Controllers
{
    public class SettingsController : Controller
    {
        private readonly SampleWebSettings _settings;

        public SettingsController(IOptions<SampleWebSettings> settingsOptions)
        {
            _settings = settingsOptions.Value;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = _settings.Title;
            ViewData["Updates"] = _settings.Updates;
            return View();
        }
    }
}
