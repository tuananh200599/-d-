using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ktra.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Posts> Posts { get; set; }
    }
}
