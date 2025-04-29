using Microsoft.AspNetCore.Mvc;
using PomodoroTimer.Models;

namespace PomodoroTimer.Controllers
{
    public class PomodoroController : Controller
    {
        private static PomodoroSettings _settings = new PomodoroSettings();

        public IActionResult Index()
        {
            return View(_settings);
        }

        [HttpPost]
        public IActionResult SaveSettings(PomodoroSettings settings)
        {
            if (ModelState.IsValid)
            {
                _settings = settings;
                return RedirectToAction("Index");
            }
            return View("Index", settings);
        }
    }
}