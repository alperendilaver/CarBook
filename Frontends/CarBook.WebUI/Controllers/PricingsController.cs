using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class PricingsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
