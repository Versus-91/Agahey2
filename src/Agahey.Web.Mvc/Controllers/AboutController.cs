using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Agahey.Controllers;

namespace Agahey.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AgaheyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
