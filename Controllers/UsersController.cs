using Microsoft.AspNetCore.Mvc;
using OkumuEgMVCAPP.Models;
namespace OkumuEgMVCAPP.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
			UsersContext uc = new();
			return View(uc.OkumuegTables.ToList());
        }
    }
}
