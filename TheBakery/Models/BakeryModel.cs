using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBakery.Models
{
    public class BakeryModel
    {
        public string Name { get; set; }
        public int Revenue { get; set; }
        public List<SandwichModel> SandwichesInStock { get; set; } = new List<SandwichModel> ();
        public List<SandwichModel> SoldSandwiches { get; set; } = new List<SandwichModel> ();
        public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>(); //all available ingredients

        public BakeryModel()
        {
            
        }

        public void SellSandwiches(SandwichModel sandwich)
        {
            SoldSandwiches.Add(sandwich);
            SandwichesInStock.Remove(sandwich);
            //Add Revenue to prop
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

        public int CalculatePrice(List<IngredientModel> ingredients)
        {
            return ingredients.Sum(i => i.Price);
        }
    }
}