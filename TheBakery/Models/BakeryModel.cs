using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void SellSandwiches(SandwichModel sandwich)
        {
            SoldSandwiches.Add(sandwich);
            SandwichesInStock.Remove(sandwich);
        }

        public void TryCreateSandwiches()
        {
            int maxIngredients = 5;

            if (maxIngredients < 5)
            {

            }
            else
            {
                MessageBox.Show("Maximaal 5 ingrediënten!");
            }
        }
    }
}
