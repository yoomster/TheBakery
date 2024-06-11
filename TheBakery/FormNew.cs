using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBakery.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeBakery
{
	public partial class FormNew : Form
	{
        //GEEN PROPERTIES!! PRAAT DIRECT MET JE BAKERYMODEL!!!

        public SandwichModel Sandwich { get; set; }
        //private List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();

        public BakeryModel Bakery;

        public FormNew()
		{
			InitializeComponent();
            Bakery.Ingredients = new List<IngredientModel>
            {
                new IngredientModel("Kip", 4),
                new IngredientModel("Steak", 5),
                new IngredientModel("Bacon", 2),
                new IngredientModel("Gehakt bal", 5),
                new IngredientModel("Veggie burger", 4),
                new IngredientModel("Gebakken ei", 2),
                new IngredientModel("Sla", 2),
                new IngredientModel("Tomaat", 2),
                new IngredientModel("ui", 2),
            };
        }
        private void FormNew_Load(object sender, EventArgs e)
        {
            comboBoxBreadType.DataSource = Enum.GetValues(typeof(BreadTypeEnum));
            listBoxIngredienten.DataSource = Bakery.Ingredients;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddIngredientsToList(SandwichModel sandwich)
        {
            //moet alleen van sandwich
            foreach (IngredientModel ingredient in listBoxIngredienten.SelectedItems)
            {
                sandwich.Ingredients.Add(ingredient);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SandwichModel sandwich = new SandwichModel
            {
                Name = textBoxName.Text,
                BreadType = (BreadTypeEnum)comboBoxBreadType.SelectedItem,

            };
            AddIngredientsToList(sandwich);



            Bakery.SandwichesInStock.Add(sandwich);
            
            this.Close();
        } 
    }
}
