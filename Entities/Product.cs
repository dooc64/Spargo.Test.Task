using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product : EntityWithId
    {
        public string Name { get; set; }

        public Product()
        {

        }

        public Product(string name)
        {
            Name = name;
        }
    }
}
