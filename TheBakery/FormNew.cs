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
	public partial class FormNew : Form
	{
        public SandwichModel Sandwich { get; set; } = new SandwichModel();
        public FormNew()
		{
			InitializeComponent();
		}


        private void buttonSave_Click(object sender, EventArgs e)
        {
            Sandwich.Name = textBoxName.Text;
            Sandwich.BreadType = comboBoxBreadType.DataSource = Enum.GetValues(typeof(BreadType));

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
