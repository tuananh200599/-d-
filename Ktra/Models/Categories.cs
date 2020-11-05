using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ktra.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Posts Posts { get; set; }
    }
}
