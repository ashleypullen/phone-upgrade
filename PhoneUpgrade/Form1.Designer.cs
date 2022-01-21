
namespace PhoneUpgrade
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoxModel = new System.Windows.Forms.ComboBox();
            this.grpBoxColour = new System.Windows.Forms.GroupBox();
            this.grpBoxStorage = new System.Windows.Forms.GroupBox();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoBlack = new System.Windows.Forms.RadioButton();
            this.chckdListContract = new System.Windows.Forms.CheckedListBox();
            this.chckdListAccessories = new System.Windows.Forms.CheckedListBox();
            this.rdo34 = new System.Windows.Forms.RadioButton();
            this.rdo64 = new System.Windows.Forms.RadioButton();
            this.rdo128 = new System.Windows.Forms.RadioButton();
            this.btnCost = new System.Windows.Forms.Button();
            this.grpBoxColour.SuspendLayout();
            this.grpBoxStorage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Choose Contract Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose Storage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Choose Accessories";
            // 
            // cmbBoxModel
            // 
            this.cmbBoxModel.FormattingEnabled = true;
            this.cmbBoxModel.Items.AddRange(new object[] {
            "iPhone 12",
            "iPhone 11",
            "iPhone SE"});
            this.cmbBoxModel.Location = new System.Drawing.Point(170, 67);
            this.cmbBoxModel.Name = "cmbBoxModel";
            this.cmbBoxModel.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxModel.TabIndex = 6;
            // 
            // grpBoxColour
            // 
            this.grpBoxColour.Controls.Add(this.rdoBlack);
            this.grpBoxColour.Controls.Add(this.rdoRed);
            this.grpBoxColour.Controls.Add(this.rdoWhite);
            this.grpBoxColour.Location = new System.Drawing.Point(170, 109);
            this.grpBoxColour.Name = "grpBoxColour";
            this.grpBoxColour.Size = new System.Drawing.Size(427, 40);
            this.grpBoxColour.TabIndex = 7;
            this.grpBoxColour.TabStop = false;
            this.grpBoxColour.Text = "Colour";
            // 
            // grpBoxStorage
            // 
            this.grpBoxStorage.Controls.Add(this.rdo128);
            this.grpBoxStorage.Controls.Add(this.rdo64);
            this.grpBoxStorage.Controls.Add(this.rdo34);
            this.grpBoxStorage.Location = new System.Drawing.Point(171, 221);
            this.grpBoxStorage.Name = "grpBoxStorage";
            this.grpBoxStorage.Size = new System.Drawing.Size(387, 37);
            this.grpBoxStorage.TabIndex = 9;
            this.grpBoxStorage.TabStop = false;
            this.grpBoxStorage.Text = "Storage";
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Location = new System.Drawing.Point(6, 13);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(53, 17);
            this.rdoWhite.TabIndex = 0;
            this.rdoWhite.TabStop = true;
            this.rdoWhite.Text = "White";
            this.rdoWhite.UseVisualStyleBackColor = true;
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(170, 13);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 17);
            this.rdoRed.TabIndex = 1;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // rdoBlack
            // 
            this.rdoBlack.AutoSize = true;
            this.rdoBlack.Location = new System.Drawing.Point(303, 13);
            this.rdoBlack.Name = "rdoBlack";
            this.rdoBlack.Size = new System.Drawing.Size(52, 17);
            this.rdoBlack.TabIndex = 2;
            this.rdoBlack.TabStop = true;
            this.rdoBlack.Text = "Black";
            this.rdoBlack.UseVisualStyleBackColor = true;
            // 
            // chckdListContract
            // 
            this.chckdListContract.FormattingEnabled = true;
            this.chckdListContract.Items.AddRange(new object[] {
            "Unlimited Texts",
            "Unlimited Data",
            "5G"});
            this.chckdListContract.Location = new System.Drawing.Point(171, 155);
            this.chckdListContract.Name = "chckdListContract";
            this.chckdListContract.Size = new System.Drawing.Size(122, 49);
            this.chckdListContract.TabIndex = 11;
            // 
            // chckdListAccessories
            // 
            this.chckdListAccessories.FormattingEnabled = true;
            this.chckdListAccessories.Items.AddRange(new object[] {
            "Bluetooth Headphones",
            "Phone Holder",
            "Screen Magnifier",
            "Phone Cover"});
            this.chckdListAccessories.Location = new System.Drawing.Point(170, 274);
            this.chckdListAccessories.Name = "chckdListAccessories";
            this.chckdListAccessories.Size = new System.Drawing.Size(143, 64);
            this.chckdListAccessories.TabIndex = 12;
            // 
            // rdo34
            // 
            this.rdo34.AutoSize = true;
            this.rdo34.Location = new System.Drawing.Point(6, 16);
            this.rdo34.Name = "rdo34";
            this.rdo34.Size = new System.Drawing.Size(52, 17);
            this.rdo34.TabIndex = 0;
            this.rdo34.TabStop = true;
            this.rdo34.Text = "34GB";
            this.rdo34.UseVisualStyleBackColor = true;
            // 
            // rdo64
            // 
            this.rdo64.AutoSize = true;
            this.rdo64.Location = new System.Drawing.Point(148, 16);
            this.rdo64.Name = "rdo64";
            this.rdo64.Size = new System.Drawing.Size(52, 17);
            this.rdo64.TabIndex = 1;
            this.rdo64.TabStop = true;
            this.rdo64.Text = "64GB";
            this.rdo64.UseVisualStyleBackColor = true;
            // 
            // rdo128
            // 
            this.rdo128.AutoSize = true;
            this.rdo128.Location = new System.Drawing.Point(296, 16);
            this.rdo128.Name = "rdo128";
            this.rdo128.Size = new System.Drawing.Size(58, 17);
            this.rdo128.TabIndex = 2;
            this.rdo128.TabStop = true;
            this.rdo128.Text = "128GB";
            this.rdo128.UseVisualStyleBackColor = true;
            // 
            // btnCost
            // 
            this.btnCost.Location = new System.Drawing.Point(75, 376);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(653, 62);
            this.btnCost.TabIndex = 13;
            this.btnCost.Text = "Calculate Monthly Cost";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCost);
            this.Controls.Add(this.chckdListAccessories);
            this.Controls.Add(this.chckdListContract);
            this.Controls.Add(this.grpBoxStorage);
            this.Controls.Add(this.grpBoxColour);
            this.Controls.Add(this.cmbBoxModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxColour.ResumeLayout(false);
            this.grpBoxColour.PerformLayout();
            this.grpBoxStorage.ResumeLayout(false);
            this.grpBoxStorage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoxModel;
        private System.Windows.Forms.GroupBox grpBoxColour;
        private System.Windows.Forms.RadioButton rdoBlack;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoWhite;
        private System.Windows.Forms.GroupBox grpBoxStorage;
        private System.Windows.Forms.RadioButton rdo128;
        private System.Windows.Forms.RadioButton rdo64;
        private System.Windows.Forms.RadioButton rdo34;
        private System.Windows.Forms.CheckedListBox chckdListContract;
        private System.Windows.Forms.CheckedListBox chckdListAccessories;
        private System.Windows.Forms.Button btnCost;
    }
}

