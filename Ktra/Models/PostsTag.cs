using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ktra.Models
{
    public class PostsTag
    {
        public int PostsId { get; set; }
        public int TagsId { get; set; }
        public Posts Posts { get; set; }
        public Tags Tags { get; set; }

    }
}
