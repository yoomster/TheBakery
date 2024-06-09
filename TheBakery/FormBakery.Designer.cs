namespace DeBakery
{
	partial class FormBakery
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.listBoxSandwiches = new System.Windows.Forms.ListBox();
            this.labelBreadTypeTitle = new System.Windows.Forms.Label();
            this.groupBoxSandwiches = new System.Windows.Forms.GroupBox();
            this.buttonNewSandwich = new System.Windows.Forms.Button();
            this.comboBoxBreadType = new System.Windows.Forms.ComboBox();
            this.buttonSell = new System.Windows.Forms.Button();
            this.groupBoxBroodjeDetails = new System.Windows.Forms.GroupBox();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.labelIngredientenTitle = new System.Windows.Forms.Label();
            this.textBoxBreadType = new System.Windows.Forms.TextBox();
            this.labelBreadTypeDetailsTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxSandwiches.SuspendLayout();
            this.groupBoxBroodjeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSandwiches
            // 
            this.listBoxSandwiches.FormattingEnabled = true;
            this.listBoxSandwiches.Location = new System.Drawing.Point(73, 40);
            this.listBoxSandwiches.Name = "listBoxSandwiches";
            this.listBoxSandwiches.Size = new System.Drawing.Size(174, 108);
            this.listBoxSandwiches.TabIndex = 1;
            // 
            // labelBreadTypeTitle
            // 
            this.labelBreadTypeTitle.AutoSize = true;
            this.labelBreadTypeTitle.Location = new System.Drawing.Point(6, 16);
            this.labelBreadTypeTitle.Name = "labelBreadTypeTitle";
            this.labelBreadTypeTitle.Size = new System.Drawing.Size(61, 13);
            this.labelBreadTypeTitle.TabIndex = 2;
            this.labelBreadTypeTitle.Text = "Brood type:";
            // 
            // groupBoxSandwiches
            // 
            this.groupBoxSandwiches.Controls.Add(this.buttonNewSandwich);
            this.groupBoxSandwiches.Controls.Add(this.comboBoxBreadType);
            this.groupBoxSandwiches.Controls.Add(this.listBoxSandwiches);
            this.groupBoxSandwiches.Controls.Add(this.labelBreadTypeTitle);
            this.groupBoxSandwiches.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSandwiches.Name = "groupBoxSandwiches";
            this.groupBoxSandwiches.Size = new System.Drawing.Size(258, 186);
            this.groupBoxSandwiches.TabIndex = 3;
            this.groupBoxSandwiches.TabStop = false;
            this.groupBoxSandwiches.Text = "Broodjes";
            // 
            // buttonNewSandwich
            // 
            this.buttonNewSandwich.Location = new System.Drawing.Point(163, 154);
            this.buttonNewSandwich.Name = "buttonNewSandwich";
            this.buttonNewSandwich.Size = new System.Drawing.Size(84, 23);
            this.buttonNewSandwich.TabIndex = 4;
            this.buttonNewSandwich.Text = "Nieuw";
            this.buttonNewSandwich.UseVisualStyleBackColor = true;
            this.buttonNewSandwich.Click += new System.EventHandler(this.buttonNewSandwich_Click);
            // 
            // comboBoxBreadType
            // 
            this.comboBoxBreadType.FormattingEnabled = true;
            this.comboBoxBreadType.Location = new System.Drawing.Point(73, 13);
            this.comboBoxBreadType.Name = "comboBoxBreadType";
            this.comboBoxBreadType.Size = new System.Drawing.Size(174, 21);
            this.comboBoxBreadType.TabIndex = 3;
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(163, 154);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(84, 23);
            this.buttonSell.TabIndex = 4;
            this.buttonSell.Text = "Verkopen";
            this.buttonSell.UseVisualStyleBackColor = true;
            // 
            // groupBoxBroodjeDetails
            // 
            this.groupBoxBroodjeDetails.Controls.Add(this.listBoxIngredients);
            this.groupBoxBroodjeDetails.Controls.Add(this.labelIngredientenTitle);
            this.groupBoxBroodjeDetails.Controls.Add(this.textBoxBreadType);
            this.groupBoxBroodjeDetails.Controls.Add(this.labelBreadTypeDetailsTitle);
            this.groupBoxBroodjeDetails.Controls.Add(this.buttonSell);
            this.groupBoxBroodjeDetails.Location = new System.Drawing.Point(276, 12);
            this.groupBoxBroodjeDetails.Name = "groupBoxBroodjeDetails";
            this.groupBoxBroodjeDetails.Size = new System.Drawing.Size(257, 186);
            this.groupBoxBroodjeDetails.TabIndex = 5;
            this.groupBoxBroodjeDetails.TabStop = false;
            this.groupBoxBroodjeDetails.Text = "Details";
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(73, 39);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxIngredients.Size = new System.Drawing.Size(174, 108);
            this.listBoxIngredients.TabIndex = 4;
            // 
            // labelIngredientenTitle
            // 
            this.labelIngredientenTitle.AutoSize = true;
            this.labelIngredientenTitle.Location = new System.Drawing.Point(6, 40);
            this.labelIngredientenTitle.Name = "labelIngredientenTitle";
            this.labelIngredientenTitle.Size = new System.Drawing.Size(69, 13);
            this.labelIngredientenTitle.TabIndex = 6;
            this.labelIngredientenTitle.Text = "Ingredienten:";
            // 
            // textBoxBreadType
            // 
            this.textBoxBreadType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBreadType.Location = new System.Drawing.Point(73, 13);
            this.textBoxBreadType.Name = "textBoxBreadType";
            this.textBoxBreadType.Size = new System.Drawing.Size(174, 20);
            this.textBoxBreadType.TabIndex = 5;
            // 
            // labelBreadTypeDetailsTitle
            // 
            this.labelBreadTypeDetailsTitle.AutoSize = true;
            this.labelBreadTypeDetailsTitle.Location = new System.Drawing.Point(6, 16);
            this.labelBreadTypeDetailsTitle.Name = "labelBreadTypeDetailsTitle";
            this.labelBreadTypeDetailsTitle.Size = new System.Drawing.Size(61, 13);
            this.labelBreadTypeDetailsTitle.TabIndex = 4;
            this.labelBreadTypeDetailsTitle.Text = "Brood type:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(449, 204);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(86, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Sluit";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 204);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Opslaan";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(102, 204);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(84, 23);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Inladen";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // FormBakery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 236);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxBroodjeDetails);
            this.Controls.Add(this.groupBoxSandwiches);
            this.Name = "FormBakery";
            this.Text = "De Bakkerij";
            this.groupBoxSandwiches.ResumeLayout(false);
            this.groupBoxSandwiches.PerformLayout();
            this.groupBoxBroodjeDetails.ResumeLayout(false);
            this.groupBoxBroodjeDetails.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox listBoxSandwiches;
		private System.Windows.Forms.Label labelBreadTypeTitle;
		private System.Windows.Forms.GroupBox groupBoxSandwiches;
		private System.Windows.Forms.ComboBox comboBoxBreadType;
		private System.Windows.Forms.Button buttonSell;
		private System.Windows.Forms.GroupBox groupBoxBroodjeDetails;
		private System.Windows.Forms.TextBox textBoxBreadType;
		private System.Windows.Forms.Label labelBreadTypeDetailsTitle;
		private System.Windows.Forms.ListBox listBoxIngredients;
		private System.Windows.Forms.Label labelIngredientenTitle;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.Button buttonNewSandwich;
	}
}

