namespace Tanaka_Electronic_Balance
{
    partial class ProductForm
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
            this.ProductCodeTextbox = new System.Windows.Forms.TextBox();
            this.ProductCodeLabel = new System.Windows.Forms.Label();
            this.ProductNameTextbox = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductWeightTextbox = new System.Windows.Forms.TextBox();
            this.ProductWeightLabel = new System.Windows.Forms.Label();
            this.ProductDescriptionLabel = new System.Windows.Forms.Label();
            this.ProductDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ProductCodeTextbox
            // 
            this.ProductCodeTextbox.Location = new System.Drawing.Point(103, 75);
            this.ProductCodeTextbox.Name = "ProductCodeTextbox";
            this.ProductCodeTextbox.Size = new System.Drawing.Size(100, 20);
            this.ProductCodeTextbox.TabIndex = 4;
            // 
            // ProductCodeLabel
            // 
            this.ProductCodeLabel.AutoSize = true;
            this.ProductCodeLabel.Location = new System.Drawing.Point(19, 82);
            this.ProductCodeLabel.Name = "ProductCodeLabel";
            this.ProductCodeLabel.Size = new System.Drawing.Size(43, 13);
            this.ProductCodeLabel.TabIndex = 2;
            this.ProductCodeLabel.Text = "Part No";
            this.ProductCodeLabel.Click += new System.EventHandler(this.ProductCodeLabel_Click);
            // 
            // ProductNameTextbox
            // 
            this.ProductNameTextbox.Location = new System.Drawing.Point(103, 39);
            this.ProductNameTextbox.Name = "ProductNameTextbox";
            this.ProductNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.ProductNameTextbox.TabIndex = 5;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(19, 39);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(75, 13);
            this.ProductNameLabel.TabIndex = 3;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductWeightTextbox
            // 
            this.ProductWeightTextbox.Location = new System.Drawing.Point(103, 112);
            this.ProductWeightTextbox.Name = "ProductWeightTextbox";
            this.ProductWeightTextbox.Size = new System.Drawing.Size(100, 20);
            this.ProductWeightTextbox.TabIndex = 4;
            // 
            // ProductWeightLabel
            // 
            this.ProductWeightLabel.AutoSize = true;
            this.ProductWeightLabel.Location = new System.Drawing.Point(19, 112);
            this.ProductWeightLabel.Name = "ProductWeightLabel";
            this.ProductWeightLabel.Size = new System.Drawing.Size(76, 13);
            this.ProductWeightLabel.TabIndex = 2;
            this.ProductWeightLabel.Text = "Weight of Item";
            this.ProductWeightLabel.Click += new System.EventHandler(this.ProductCodeLabel_Click);
            // 
            // ProductDescriptionLabel
            // 
            this.ProductDescriptionLabel.AutoSize = true;
            this.ProductDescriptionLabel.Location = new System.Drawing.Point(22, 153);
            this.ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            this.ProductDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.ProductDescriptionLabel.TabIndex = 6;
            this.ProductDescriptionLabel.Text = "Description";
            // 
            // ProductDescriptionTextBox
            // 
            this.ProductDescriptionTextBox.Location = new System.Drawing.Point(103, 153);
            this.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            this.ProductDescriptionTextBox.Size = new System.Drawing.Size(169, 96);
            this.ProductDescriptionTextBox.TabIndex = 7;
            this.ProductDescriptionTextBox.Text = "";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ProductDescriptionTextBox);
            this.Controls.Add(this.ProductDescriptionLabel);
            this.Controls.Add(this.ProductWeightTextbox);
            this.Controls.Add(this.ProductCodeTextbox);
            this.Controls.Add(this.ProductWeightLabel);
            this.Controls.Add(this.ProductCodeLabel);
            this.Controls.Add(this.ProductNameTextbox);
            this.Controls.Add(this.ProductNameLabel);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductCodeTextbox;
        private System.Windows.Forms.Label ProductCodeLabel;
        private System.Windows.Forms.TextBox ProductNameTextbox;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductWeightTextbox;
        private System.Windows.Forms.Label ProductWeightLabel;
        private System.Windows.Forms.Label ProductDescriptionLabel;
        private System.Windows.Forms.RichTextBox ProductDescriptionTextBox;
    }
}