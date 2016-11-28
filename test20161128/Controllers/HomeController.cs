using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace test20161128.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono1" : ".NET2";

			return View();
		}
	}
}
