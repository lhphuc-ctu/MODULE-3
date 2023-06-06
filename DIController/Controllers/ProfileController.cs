using DIController.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DIController.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            // A real app would up profile based on the user.
            var profile = new Profile()
            {
                Name = "Rick",
                FavColor = "Blue",
                Gender = "Male",
                State = new State("Ohio", "OH")
            };
            return View(profile);
        }
    }
}
