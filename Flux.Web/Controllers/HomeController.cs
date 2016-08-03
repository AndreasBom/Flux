using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Flux.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FluxControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}