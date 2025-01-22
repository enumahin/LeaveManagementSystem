using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            TestViewModel client = new TestViewModel {
                Name = "Iyke Melody",
                DateOfBirth = new DateTime(1984, 10, 09)
            };
            return View(client);
        }
    }
}
