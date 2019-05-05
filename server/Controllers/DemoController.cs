using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    public class DemoController : BaseController
    {
        /// <summary>
        /// Get A List of Post
        /// </summary>
        [HttpGet]
        public ActionResult<string> List()
        {
            return "A List";
        }

        /// <summary>
        /// Get a Post
        /// </summary>
        /// <param name="id">Post Id</param>
        [HttpGet("{id:int}")]
        public ActionResult<string> Get(int id)
        {
            return "An item";
        }

        /// <summary>
        /// Create a new Post
        /// </summary>
        [HttpPost]
        public ActionResult<string> Post()
        {
            return "Post";
        }
    }
}