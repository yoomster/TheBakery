using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeBakery
{
	public partial class FormBakery : Form
	{
		public FormBakery()
		{
			InitializeComponent();
		}

        private void buttonNewSandwich_Click(object sender, EventArgs e)
        {
			FormNew createSandwichForm = new FormNew();
			createSandwichForm.Show();
        }
    }
}
