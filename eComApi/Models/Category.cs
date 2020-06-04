using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eComApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
