using Agahey.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Agahey.Web.Controllers
{
    public class ManageController : AgaheyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
