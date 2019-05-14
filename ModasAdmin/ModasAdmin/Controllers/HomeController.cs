using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace ModasAdmin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}