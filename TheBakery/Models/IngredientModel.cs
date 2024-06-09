using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBakery.Models
{
    public class IngredientModel
    {
        public string Name { get; set; }
        private int Price { get; set; }

        public IngredientModel(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name;
        }

        public void CalculatePrice(string ingredient)
        {
            if (ingredient == "kip")
            {
                Price += 4;
            }
            else if (ingredient == "steak")
            {
                Price += 5;
            }
            else if (ingredient == "bacon")
            {
                Price += 2;
            }
            else if (ingredient == "Gehakt bal")
            {
                Price += 1;
            }
            else if (ingredient == "veggie burger")
            {
                Price += 1;
            }
            else if (ingredient == "gebakken ei")
            {
                Price += 1;
            }
        }
    }
}
