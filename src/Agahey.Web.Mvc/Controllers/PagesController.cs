using Agahey.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Agahey.Web.Controllers
{
    public class PagesController : AgaheyControllerBase
    {
        public PagesController()
        {

        }

        [Route("Pages/manage")]
        public IActionResult Manage()
        {
            return View();
        }

        [Route("Pages/{name}")]
        public IActionResult Index(string name)
        {
            ViewData["page"] = name;
            return View();
        }


    }
}
