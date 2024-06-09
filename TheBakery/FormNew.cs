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
        public SandwichModel Sandwich { get; set; } = new SandwichModel();
        private List<IngredientModel> Ingredients { get; set; }
        public FormNew()
		{
			InitializeComponent();

            Ingredients = new List<IngredientModel>
            {
                new IngredientModel("Kip", 4),
                new IngredientModel("Steak", 5),
                new IngredientModel("Bacon", 2),
                new IngredientModel("Gehakt Bal", 5),
                new IngredientModel("Veggie Burger", 4),
                new IngredientModel("Gebakken Ei", 2)
            };
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Sandwich.Name = textBoxName.Text;
            //Sandwich.Price = ;
            Sandwich.BreadType = (BreadTypeEnum)comboBoxBreadType.SelectedItem;
            Sandwich.Ingredients = Ingredients;
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            comboBoxBreadType.DataSource = Enum.GetValues(typeof(BreadTypeEnum));
            listBoxIngredienten.DataSource = Ingredients;

        }
    }
}
