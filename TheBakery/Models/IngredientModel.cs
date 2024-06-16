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
        public int Price { get; set; }

        public IngredientModel(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name ;
        }

        //public int GetName()
        //{
        //    return this.Name;
        //}

        //public int SetName()
        //{
        //    return this.leeftijd;
        //}

        //public int GetLeeftijd()
        //{
        //    return this.leeftijd;
        //}
    }
}
