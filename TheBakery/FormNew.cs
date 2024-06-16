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
        public BakeryModel Bakery;


        public FormNew()
		{
            InitializeComponent();
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

        public void AddSelectedIngredients(SandwichModel sandwich)
        {
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
            AddSelectedIngredients(sandwich);

            //UpdateSandwichesInStock(Bakery.SandwichesInStock);

            this.Close();
        }


    }
}

//Must loads at opening:
//combo box is populated with breadtypes
//listbox is populated with all ingredients
//create a new sandwich

//UI activities:
//MUST give in a name for new sandwich
//Select a bread type
//Select ingredients to go on sandwich
//min 1 and max 5 ingredients
//cancel and close by pressing Cancel button
//save sandwich into a list of InStockSandw and close by pressing Save button

//cool to have
//After clicking Save Button -> Save sandwich to stock items AND ask if they want to add another one on done
