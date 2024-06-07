using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBakery.Models
{
    internal class BakeryModel
    {
        public string Name { get; set; }
        public int Revenue { get; set; }
        public List<IngredientModel> Ingredients { get; set; }
        public List<SandwichModel> SandwichesInStock { get; set; }
        public List<SandwichModel> SoldSandwiches { get; set; }

        public BakeryModel()
        {
            
        }

        public void SellSandwiches()
        {

        }

        public void CreateSandwiches()
        {

        }
    }
}
