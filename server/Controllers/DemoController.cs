using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [Route("api/[controller]")]
    public class DemoController : Controller
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
            return "Index";
        }
    }
}