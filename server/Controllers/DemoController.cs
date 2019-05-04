using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    public class DemoController : BaseController
    {
        // GET api/demo
        [HttpGet]
        public ActionResult<string> List()
        {
            return "A List";
        }

        // GET /api/demo/7
        [HttpGet("{id:int}")]
        public ActionResult<string> Get(int id)
        {
            return "An item";
        }

        //POST /api/demo
        public ActionResult<string> Post()
        {
            return "Post";
        }
    }
}