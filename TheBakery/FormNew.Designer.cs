using System;

namespace DeBakery
{
	partial class FormNew
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
            this.groupBoxNewSandwich = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNameTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxBreadType = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxIngredienten = new System.Windows.Forms.ListBox();
            this.labelBreadTypeTitle = new System.Windows.Forms.Label();
            this.groupBoxNewSandwich.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewSandwich
            // 
            this.groupBoxNewSandwich.Controls.Add(this.textBoxName);
            this.groupBoxNewSandwich.Controls.Add(this.labelNameTitle);
            this.groupBoxNewSandwich.Controls.Add(this.buttonCancel);
            this.groupBoxNewSandwich.Controls.Add(this.comboBoxBreadType);
            this.groupBoxNewSandwich.Controls.Add(this.buttonSave);
            this.groupBoxNewSandwich.Controls.Add(this.listBoxIngredienten);
            this.groupBoxNewSandwich.Controls.Add(this.labelBreadTypeTitle);
            this.groupBoxNewSandwich.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNewSandwich.Name = "groupBoxNewSandwich";
            this.groupBoxNewSandwich.Size = new System.Drawing.Size(258, 220);
            this.groupBoxNewSandwich.TabIndex = 4;
            this.groupBoxNewSandwich.TabStop = false;
            this.groupBoxNewSandwich.Text = "Nieuw";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(78, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // labelNameTitle
            // 
            this.labelNameTitle.AutoSize = true;
            this.labelNameTitle.Location = new System.Drawing.Point(11, 22);
            this.labelNameTitle.Name = "labelNameTitle";
            this.labelNameTitle.Size = new System.Drawing.Size(38, 13);
            this.labelNameTitle.TabIndex = 5;
            this.labelNameTitle.Text = "Name:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(78, 186);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Annuleren";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxBreadType
            // 
            this.comboBoxBreadType.FormattingEnabled = true;
            this.comboBoxBreadType.Location = new System.Drawing.Point(78, 45);
            this.comboBoxBreadType.Name = "comboBoxBreadType";
            this.comboBoxBreadType.Size = new System.Drawing.Size(174, 21);
            this.comboBoxBreadType.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(168, 186);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Opslaan";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxIngredienten
            // 
            this.listBoxIngredienten.FormattingEnabled = true;
            this.listBoxIngredienten.Location = new System.Drawing.Point(78, 72);
            this.listBoxIngredienten.Name = "listBoxIngredienten";
            this.listBoxIngredienten.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxIngredienten.Size = new System.Drawing.Size(174, 108);
            this.listBoxIngredienten.TabIndex = 1;
            // 
            // labelBreadTypeTitle
            // 
            this.labelBreadTypeTitle.AutoSize = true;
            this.labelBreadTypeTitle.Location = new System.Drawing.Point(11, 48);
            this.labelBreadTypeTitle.Name = "labelBreadTypeTitle";
            this.labelBreadTypeTitle.Size = new System.Drawing.Size(61, 13);
            this.labelBreadTypeTitle.TabIndex = 2;
            this.labelBreadTypeTitle.Text = "Brood type:";
            // 
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 243);
            this.Controls.Add(this.groupBoxNewSandwich);
            this.Name = "FormNew";
            this.Text = "Nieuw broodje";
            this.Load += new System.EventHandler(this.FormNew_Load);
            this.groupBoxNewSandwich.ResumeLayout(false);
            this.groupBoxNewSandwich.PerformLayout();
            this.ResumeLayout(false);

		}



        #endregion

        private System.Windows.Forms.GroupBox groupBoxNewSandwich;
		private System.Windows.Forms.ComboBox comboBoxBreadType;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ListBox listBoxIngredienten;
		private System.Windows.Forms.Label labelBreadTypeTitle;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelNameTitle;
		private System.Windows.Forms.TextBox textBoxName;
	}
}