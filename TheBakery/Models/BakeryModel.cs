using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBakery.Models
{
    public class BakeryModel
    {
        public string Name { get; set; }
        public int Revenue { get; set; }
        public List<SandwichModel> SandwichesInStock { get; set; }
        public List<SandwichModel> SoldSandwiches { get; set; }

        public BakeryModel()
        {
            
        }

        public void SellSandwiches(SandwichModel sandwich)
        {
            SoldSandwiches.Add(sandwich);
            SandwichesInStock.Remove(sandwich);
        }

        public void CreateSandwiches(string name, BreadTypeEnum breadType, List<IngredientModel> ingredients)
        {
            SandwichModel newSandwich = new SandwichModel
            {
                Name = name,
                BreadType = breadType,
                Ingredients = ingredients
            };
            SandwichesInStock.Add(newSandwich);
        }

        public int CalculatePrice()
        {
            int output = 0;

            foreach (var ingredient in Ingredients)
            {

                if (ingredient.Name == "Kip")
                {
                    output += 4;
                }
                else if (ingredient.Name == "Steak")
                {
                    output += 5;
                }
                else if (ingredient.Name == "Bacon")
                {
                    output += 2;
                }
                else if (ingredient.Name == "Gehakt bal")
                {
                    output += 1;
                }
                else if (ingredient.Name == "Veggie burger")
                {
                    output += 1;
                }
                else if (ingredient.Name == "Gebakken ei")
                {
                    output += 1;
                }
            }
            return output;
        }
    }
}
