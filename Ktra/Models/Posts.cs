using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ktra.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public Tags Tags { get; set; }
        public List<Categories> Categories { get; set; }

    }
}
