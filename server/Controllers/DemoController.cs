using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet("/products")]
        public ActionResult<string> ListProducts()
        {
            return "ListProducts";
        }

        [Route("")]
        [Route("Demo")]
        [Route("Demo/Index")]
        public ActionResult<string> Index()
        {
            return "Index";
        }

        [Route("Demo/About")]
        public ActionResult<string> About()
        {
            return "About";
        }
    }
}