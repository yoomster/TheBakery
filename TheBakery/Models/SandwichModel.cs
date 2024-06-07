using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBakery.Models
{
    internal class SandwichModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public BreadTypeEnum BreadType { get; set; }
    }
}

