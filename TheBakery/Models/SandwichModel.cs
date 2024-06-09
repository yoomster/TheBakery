using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBakery.Models
{
    public class SandwichModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public BreadTypeEnum BreadType { get; set; }
        public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();


        public int CalculatePrice()
        {
            int output = 0;

            foreach (var ingredient in Ingredients)
            {

                if (ingredient.Name == "kip")
                {
                    output += 4;
                }
                else if (ingredient.Name == "steak")
                {
                    output += 5;
                }
                else if (ingredient.Name == "bacon")
                {
                    output += 2;
                }
                else if (ingredient.Name == "Gehakt bal")
                {
                    output += 1;
                }
                else if (ingredient.Name == "veggie burger")
                {
                    output += 1;
                }
                else if (ingredient.Name == "gebakken ei")
                {
                    output += 1;
                }
            }
            return output;
        }
    }
}

