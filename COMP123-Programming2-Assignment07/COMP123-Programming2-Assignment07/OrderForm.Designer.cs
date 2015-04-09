namespace COMP123_Programming2_Assignment07
{
    partial class OrderForm
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
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.LargeGraphicPictureBox = new System.Windows.Forms.PictureBox();
            this.YourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderCheckBox = new System.Windows.Forms.CheckBox();
            this.AdditionalChargeTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalChargeLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.MovieSalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.MovieSalesTaxLabel = new System.Windows.Forms.Label();
            this.MovieSubTotalTextBox = new System.Windows.Forms.TextBox();
            this.MovieSubTotalLabel = new System.Windows.Forms.Label();
            this.MovieCostTextBox = new System.Windows.Forms.TextBox();
            this.MovieCostLabel = new System.Windows.Forms.Label();
            this.MovieCategoryTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MovieCategoryLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderMenuStrip.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LargeGraphicPictureBox)).BeginInit();
            this.YourOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Size = new System.Drawing.Size(664, 33);
            this.OrderMenuStrip.TabIndex = 0;
            this.OrderMenuStrip.Text = "Order Menu Strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.screamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // screamToolStripMenuItem
            // 
            this.screamToolStripMenuItem.Name = "screamToolStripMenuItem";
            this.screamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.screamToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.screamToolStripMenuItem.Text = "Screa&m";
            this.screamToolStripMenuItem.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.cancelToolStripMenuItem.Text = "Canc&el";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(440, 379);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 35);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamButton.Location = new System.Drawing.Point(556, 379);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(96, 35);
            this.StreamButton.TabIndex = 7;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            this.StreamButton.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.LargeGraphicPictureBox);
            this.MovieSelectedGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(19, 51);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(302, 363);
            this.MovieSelectedGroupBox.TabIndex = 8;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            // 
            // LargeGraphicPictureBox
            // 
            this.LargeGraphicPictureBox.Image = global::COMP123_Programming2_Assignment07.Properties.Resources.companymen;
            this.LargeGraphicPictureBox.Location = new System.Drawing.Point(15, 142);
            this.LargeGraphicPictureBox.Name = "LargeGraphicPictureBox";
            this.LargeGraphicPictureBox.Size = new System.Drawing.Size(256, 221);
            this.LargeGraphicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LargeGraphicPictureBox.TabIndex = 12;
            this.LargeGraphicPictureBox.TabStop = false;
            // 
            // YourOrderGroupBox
            // 
            this.YourOrderGroupBox.Controls.Add(this.OrderCheckBox);
            this.YourOrderGroupBox.Controls.Add(this.AdditionalChargeTextBox);
            this.YourOrderGroupBox.Controls.Add(this.AdditionalChargeLabel);
            this.YourOrderGroupBox.Controls.Add(this.textBox3);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.MovieSalesTaxTextBox);
            this.YourOrderGroupBox.Controls.Add(this.MovieSalesTaxLabel);
            this.YourOrderGroupBox.Controls.Add(this.MovieSubTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.MovieSubTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.MovieCostTextBox);
            this.YourOrderGroupBox.Controls.Add(this.MovieCostLabel);
            this.YourOrderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourOrderGroupBox.Location = new System.Drawing.Point(335, 51);
            this.YourOrderGroupBox.Name = "YourOrderGroupBox";
            this.YourOrderGroupBox.Size = new System.Drawing.Size(317, 301);
            this.YourOrderGroupBox.TabIndex = 9;
            this.YourOrderGroupBox.TabStop = false;
            this.YourOrderGroupBox.Text = "Your Order";
            // 
            // OrderCheckBox
            // 
            this.OrderCheckBox.AutoSize = true;
            this.OrderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCheckBox.Location = new System.Drawing.Point(9, 275);
            this.OrderCheckBox.Name = "OrderCheckBox";
            this.OrderCheckBox.Size = new System.Drawing.Size(312, 20);
            this.OrderCheckBox.TabIndex = 23;
            this.OrderCheckBox.Text = "Order the DVD(adds $10.00 to your order)";
            this.OrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdditionalChargeTextBox
            // 
            this.AdditionalChargeTextBox.Location = new System.Drawing.Point(189, 83);
            this.AdditionalChargeTextBox.Name = "AdditionalChargeTextBox";
            this.AdditionalChargeTextBox.ReadOnly = true;
            this.AdditionalChargeTextBox.Size = new System.Drawing.Size(113, 29);
            this.AdditionalChargeTextBox.TabIndex = 21;
            this.AdditionalChargeTextBox.Visible = false;
            // 
            // AdditionalChargeLabel
            // 
            this.AdditionalChargeLabel.AutoSize = true;
            this.AdditionalChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalChargeLabel.Location = new System.Drawing.Point(12, 85);
            this.AdditionalChargeLabel.Name = "AdditionalChargeLabel";
            this.AdditionalChargeLabel.Size = new System.Drawing.Size(160, 24);
            this.AdditionalChargeLabel.TabIndex = 22;
            this.AdditionalChargeLabel.Text = "Additional Charge";
            this.AdditionalChargeLabel.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(189, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(113, 29);
            this.textBox3.TabIndex = 19;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalLabel.Location = new System.Drawing.Point(64, 223);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(108, 24);
            this.GrandTotalLabel.TabIndex = 20;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // MovieSalesTaxTextBox
            // 
            this.MovieSalesTaxTextBox.Location = new System.Drawing.Point(189, 172);
            this.MovieSalesTaxTextBox.Name = "MovieSalesTaxTextBox";
            this.MovieSalesTaxTextBox.ReadOnly = true;
            this.MovieSalesTaxTextBox.Size = new System.Drawing.Size(113, 29);
            this.MovieSalesTaxTextBox.TabIndex = 17;
            // 
            // MovieSalesTaxLabel
            // 
            this.MovieSalesTaxLabel.AutoSize = true;
            this.MovieSalesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieSalesTaxLabel.Location = new System.Drawing.Point(32, 174);
            this.MovieSalesTaxLabel.Name = "MovieSalesTaxLabel";
            this.MovieSalesTaxLabel.Size = new System.Drawing.Size(140, 24);
            this.MovieSalesTaxLabel.TabIndex = 18;
            this.MovieSalesTaxLabel.Text = "Sales Tax(13%)";
            // 
            // MovieSubTotalTextBox
            // 
            this.MovieSubTotalTextBox.Location = new System.Drawing.Point(189, 126);
            this.MovieSubTotalTextBox.Name = "MovieSubTotalTextBox";
            this.MovieSubTotalTextBox.ReadOnly = true;
            this.MovieSubTotalTextBox.Size = new System.Drawing.Size(113, 29);
            this.MovieSubTotalTextBox.TabIndex = 15;
            // 
            // MovieSubTotalLabel
            // 
            this.MovieSubTotalLabel.AutoSize = true;
            this.MovieSubTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieSubTotalLabel.Location = new System.Drawing.Point(87, 128);
            this.MovieSubTotalLabel.Name = "MovieSubTotalLabel";
            this.MovieSubTotalLabel.Size = new System.Drawing.Size(85, 24);
            this.MovieSubTotalLabel.TabIndex = 16;
            this.MovieSubTotalLabel.Text = "SubTotal";
            // 
            // MovieCostTextBox
            // 
            this.MovieCostTextBox.Location = new System.Drawing.Point(189, 38);
            this.MovieCostTextBox.Name = "MovieCostTextBox";
            this.MovieCostTextBox.ReadOnly = true;
            this.MovieCostTextBox.Size = new System.Drawing.Size(113, 29);
            this.MovieCostTextBox.TabIndex = 14;
            // 
            // MovieCostLabel
            // 
            this.MovieCostLabel.AutoSize = true;
            this.MovieCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCostLabel.Location = new System.Drawing.Point(125, 40);
            this.MovieCostLabel.Name = "MovieCostLabel";
            this.MovieCostLabel.Size = new System.Drawing.Size(47, 24);
            this.MovieCostLabel.TabIndex = 14;
            this.MovieCostLabel.Text = "Cost";
            // 
            // MovieCategoryTextBox
            // 
            this.MovieCategoryTextBox.Location = new System.Drawing.Point(34, 161);
            this.MovieCategoryTextBox.Name = "MovieCategoryTextBox";
            this.MovieCategoryTextBox.ReadOnly = true;
            this.MovieCategoryTextBox.Size = new System.Drawing.Size(256, 20);
            this.MovieCategoryTextBox.TabIndex = 13;
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(34, 109);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(256, 20);
            this.MovieTitleTextBox.TabIndex = 12;
            // 
            // MovieCategoryLabel
            // 
            this.MovieCategoryLabel.AutoSize = true;
            this.MovieCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCategoryLabel.Location = new System.Drawing.Point(38, 134);
            this.MovieCategoryLabel.Name = "MovieCategoryLabel";
            this.MovieCategoryLabel.Size = new System.Drawing.Size(85, 24);
            this.MovieCategoryLabel.TabIndex = 11;
            this.MovieCategoryLabel.Text = "Category";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.Location = new System.Drawing.Point(38, 81);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(45, 24);
            this.MovieTitleLabel.TabIndex = 10;
            this.MovieTitleLabel.Text = "Title";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(335, 379);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(88, 35);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 426);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MovieCategoryTextBox);
            this.Controls.Add(this.MovieTitleTextBox);
            this.Controls.Add(this.MovieCategoryLabel);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.YourOrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OrderMenuStrip);
            this.MainMenuStrip = this.OrderMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.Text = "Your Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LargeGraphicPictureBox)).EndInit();
            this.YourOrderGroupBox.ResumeLayout(false);
            this.YourOrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.GroupBox YourOrderGroupBox;
        private System.Windows.Forms.TextBox MovieCategoryTextBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.Label MovieCategoryLabel;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.PictureBox LargeGraphicPictureBox;
        private System.Windows.Forms.TextBox AdditionalChargeTextBox;
        private System.Windows.Forms.Label AdditionalChargeLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.TextBox MovieSalesTaxTextBox;
        private System.Windows.Forms.Label MovieSalesTaxLabel;
        private System.Windows.Forms.TextBox MovieSubTotalTextBox;
        private System.Windows.Forms.Label MovieSubTotalLabel;
        private System.Windows.Forms.TextBox MovieCostTextBox;
        private System.Windows.Forms.Label MovieCostLabel;
        private System.Windows.Forms.CheckBox OrderCheckBox;
        private System.Windows.Forms.Button BackButton;
    }
}