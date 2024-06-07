using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBakery.Models
{
    internal class IngredientModel
    {
        public string Name { get; set; }
        private int Price { get; set; }

        public int AddIngredient(int price)
        {
            return price += Price;
        }
    }
}
