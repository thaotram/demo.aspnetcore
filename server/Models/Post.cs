using System;
using Realms;
using server.Models.Interfaces;

namespace server.Models
{
    public class Post : RealmObject, IModelHasId
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Content { get; set; }
    }
}