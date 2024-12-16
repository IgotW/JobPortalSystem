using Microsoft.AspNetCore.Mvc;

namespace JobSystem.Controllers
{
	public class CandidateController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
