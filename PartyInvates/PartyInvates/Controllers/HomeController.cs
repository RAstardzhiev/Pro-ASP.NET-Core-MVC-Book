namespace PartyInvates.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Linq;
    using Models;

    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greating = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm() => View();

        [HttpPost]
        public ViewResult RsvpForm(GuestResponce guestResponce)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponce);
                return View("Thanks", guestResponce);
            }
            else // There is a validation error
            {
                return View();
            }
        }

        public ViewResult ListResponses() => View(Repository.Responces.Where(r => r.WillAttend == true));
    }
}
