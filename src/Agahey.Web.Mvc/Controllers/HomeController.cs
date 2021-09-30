using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Agahey.Controllers;

namespace Agahey.Web.Controllers
{
    public class HomeController : AgaheyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
