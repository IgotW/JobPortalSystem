using Microsoft.AspNetCore.Mvc;

namespace JobSystem.Controllers
{
	public class CompanyController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	}
}
