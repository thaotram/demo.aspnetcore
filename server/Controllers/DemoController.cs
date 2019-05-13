using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Realms;
using server.Models;

namespace server.Controllers
{
    public class DemoController : BaseController
    {
        private Realm realm => Realm.GetInstance();
        private IQueryable<Post> list => realm.All<Post>();
        private int NextId => list.Count() == 0 ? 1 : list.AsEnumerable().Max(p => p.Id) + 1;

        /// <summary>
        /// Get A List of Post
        /// </summary>
        [HttpGet]
        public ActionResult<List<Post>> List() => list.ToList();

        /// <summary>
        /// Get a Post
        /// </summary>
        /// <param name="id">Post Id</param>
        [HttpGet("{id:int}")]
        public ActionResult<Post> Get(int id)
        {
            var post = realm.Find<Post>(id);
            if(post == null) return NotFound("Item not found");
            return post;
        }

        /// <summary>
        /// Create a new Post
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<Post>> Post()
        {
            var post = new Post()
            {
                Id = NextId,
                Content = "Content",
                Title = "Title",
                Created = new System.DateTimeOffset()
            };
            await realm.WriteAsync(r => post = r.Add(post));
            return post;
        }
    }
}