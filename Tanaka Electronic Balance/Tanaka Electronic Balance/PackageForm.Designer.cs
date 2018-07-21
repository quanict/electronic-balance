namespace Tanaka_Electronic_Balance
{
    partial class PackageForm
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
            this.PackageRankTextbox = new System.Windows.Forms.TextBox();
            this.PackageNumberTextbox = new System.Windows.Forms.TextBox();
            this.PackageRankLabel = new System.Windows.Forms.Label();
            this.PackageNumberLabel = new System.Windows.Forms.Label();
            this.PackageCodeTextbox = new System.Windows.Forms.TextBox();
            this.PackageCodeLabel = new System.Windows.Forms.Label();
            this.PackageDatetimeLabel = new System.Windows.Forms.Label();
            this.PackageButtonPrintBtn = new System.Windows.Forms.Button();
            this.PackageTotalLabel = new System.Windows.Forms.Label();
            this.PackageTotalTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PackageRankTextbox
            // 
            this.PackageRankTextbox.Location = new System.Drawing.Point(99, 109);
            this.PackageRankTextbox.Name = "PackageRankTextbox";
            this.PackageRankTextbox.Size = new System.Drawing.Size(100, 20);
            this.PackageRankTextbox.TabIndex = 9;
            // 
            // PackageNumberTextbox
            // 
            this.PackageNumberTextbox.Location = new System.Drawing.Point(99, 72);
            this.PackageNumberTextbox.Name = "PackageNumberTextbox";
            this.PackageNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.PackageNumberTextbox.TabIndex = 10;
            // 
            // PackageRankLabel
            // 
            this.PackageRankLabel.AutoSize = true;
            this.PackageRankLabel.Location = new System.Drawing.Point(15, 109);
            this.PackageRankLabel.Name = "PackageRankLabel";
            this.PackageRankLabel.Size = new System.Drawing.Size(33, 13);
            this.PackageRankLabel.TabIndex = 6;
            this.PackageRankLabel.Text = "Rank";
            // 
            // PackageNumberLabel
            // 
            this.PackageNumberLabel.AutoSize = true;
            this.PackageNumberLabel.Location = new System.Drawing.Point(15, 79);
            this.PackageNumberLabel.Name = "PackageNumberLabel";
            this.PackageNumberLabel.Size = new System.Drawing.Size(39, 13);
            this.PackageNumberLabel.TabIndex = 7;
            this.PackageNumberLabel.Text = "Lot No";
            // 
            // PackageCodeTextbox
            // 
            this.PackageCodeTextbox.Location = new System.Drawing.Point(99, 36);
            this.PackageCodeTextbox.Name = "PackageCodeTextbox";
            this.PackageCodeTextbox.Size = new System.Drawing.Size(100, 20);
            this.PackageCodeTextbox.TabIndex = 11;
            // 
            // PackageCodeLabel
            // 
            this.PackageCodeLabel.AutoSize = true;
            this.PackageCodeLabel.Location = new System.Drawing.Point(15, 36);
            this.PackageCodeLabel.Name = "PackageCodeLabel";
            this.PackageCodeLabel.Size = new System.Drawing.Size(78, 13);
            this.PackageCodeLabel.TabIndex = 8;
            this.PackageCodeLabel.Text = "Package Code";
            this.PackageCodeLabel.UseMnemonic = false;
            // 
            // PackageDatetimeLabel
            // 
            this.PackageDatetimeLabel.AutoSize = true;
            this.PackageDatetimeLabel.Location = new System.Drawing.Point(18, 170);
            this.PackageDatetimeLabel.Name = "PackageDatetimeLabel";
            this.PackageDatetimeLabel.Size = new System.Drawing.Size(76, 13);
            this.PackageDatetimeLabel.TabIndex = 12;
            this.PackageDatetimeLabel.Text = "Datetime Input";
            this.PackageDatetimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PackageButtonPrintBtn
            // 
            this.PackageButtonPrintBtn.Location = new System.Drawing.Point(197, 226);
            this.PackageButtonPrintBtn.Name = "PackageButtonPrintBtn";
            this.PackageButtonPrintBtn.Size = new System.Drawing.Size(75, 23);
            this.PackageButtonPrintBtn.TabIndex = 13;
            this.PackageButtonPrintBtn.Text = "Print";
            this.PackageButtonPrintBtn.UseVisualStyleBackColor = true;
            // 
            // PackageTotalLabel
            // 
            this.PackageTotalLabel.AutoSize = true;
            this.PackageTotalLabel.Location = new System.Drawing.Point(15, 139);
            this.PackageTotalLabel.Name = "PackageTotalLabel";
            this.PackageTotalLabel.Size = new System.Drawing.Size(31, 13);
            this.PackageTotalLabel.TabIndex = 6;
            this.PackageTotalLabel.Text = "Total";
            // 
            // PackageTotalTextbox
            // 
            this.PackageTotalTextbox.Location = new System.Drawing.Point(99, 139);
            this.PackageTotalTextbox.Name = "PackageTotalTextbox";
            this.PackageTotalTextbox.Size = new System.Drawing.Size(100, 20);
            this.PackageTotalTextbox.TabIndex = 9;
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PackageButtonPrintBtn);
            this.Controls.Add(this.PackageDatetimeLabel);
            this.Controls.Add(this.PackageTotalTextbox);
            this.Controls.Add(this.PackageRankTextbox);
            this.Controls.Add(this.PackageNumberTextbox);
            this.Controls.Add(this.PackageTotalLabel);
            this.Controls.Add(this.PackageRankLabel);
            this.Controls.Add(this.PackageNumberLabel);
            this.Controls.Add(this.PackageCodeTextbox);
            this.Controls.Add(this.PackageCodeLabel);
            this.Name = "PackageForm";
            this.Text = "PackageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PackageRankTextbox;
        private System.Windows.Forms.TextBox PackageNumberTextbox;
        private System.Windows.Forms.Label PackageRankLabel;
        private System.Windows.Forms.Label PackageNumberLabel;
        private System.Windows.Forms.TextBox PackageCodeTextbox;
        private System.Windows.Forms.Label PackageCodeLabel;
        private System.Windows.Forms.Label PackageDatetimeLabel;
        private System.Windows.Forms.Button PackageButtonPrintBtn;
        private System.Windows.Forms.Label PackageTotalLabel;
        private System.Windows.Forms.TextBox PackageTotalTextbox;
    }
}