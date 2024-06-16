using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBakery.Models;

namespace DeBakery
{
	public partial class FormBakery : Form
	{
        public BakeryModel Bakery;

        public FormBakery()
		{
			InitializeComponent();
            this.Bakery = new BakeryModel();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNewSandwich_Click(object sender, EventArgs e)
        {
			FormNew newSandwichForm = new FormNew();
            newSandwichForm.Bakery = Bakery;
			DialogResult response = newSandwichForm.ShowDialog();

            if (response == DialogResult.OK)
            {

            }
            if (response == DialogResult.Cancel)
            {

            }
        }

        private void FormBakery_Load(object sender, EventArgs e)
        {
            RenderSandwichesInStock(Bakery.SandwichesInStock);
        }

        public void RenderSandwichesInStock(List <SandwichModel> sandwichesInStock)
        {
            Bakery.SandwichesInStock.Clear();

            foreach (var sandwich in sandwichesInStock)
            {
                listBoxSandwiches.Items.Add(sandwich.Name);
            }
            // OR??

            //listBoxSandwiches.DataSource = Bakery.SandwichesInStock;
        }
    }
}
