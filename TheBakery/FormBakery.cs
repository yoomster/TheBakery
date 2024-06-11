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
        private BakeryModel bakery;

        public FormBakery()
		{
			InitializeComponent();
            this.bakery = new BakeryModel();

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNewSandwich_Click(object sender, EventArgs e)
        {
			FormNew createSandwichForm = new FormNew();
			createSandwichForm.Show();
        }

        private void FormBakery_Load(object sender, EventArgs e)
        {
            listBoxSandwiches.DataSource = bakery.SandwichesInStock;
        }
    }
}
