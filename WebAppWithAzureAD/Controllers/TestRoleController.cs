using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAppWithAzureAD.Controllers
{
    public class TestRoleController : Controller
    {
        [Authorize(Policy = "Admins")]
        public IActionResult Index()
        {
            ViewBag.WhoYouAre = "You are an admin";
            return View("Index");
        }

        [Authorize(Policy = "Test")]
        public IActionResult Test()
        {
            ViewBag.WhoYouAre = "You are a test";
            return View("Index");
        }

        [Authorize(Policy = "CrossZone")]
        public IActionResult CrossZone()
        {
            ViewBag.WhoYouAre = "You are in CrossZone";
            return View("Index");
        }
    }
}