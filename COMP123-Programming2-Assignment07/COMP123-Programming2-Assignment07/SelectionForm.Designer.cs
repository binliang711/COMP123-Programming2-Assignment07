namespace COMP123_Programming2_Assignment07
{
    partial class SelectionForm
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
            this.CurrentMoviesLabel = new System.Windows.Forms.Label();
            this.PomptLabel = new System.Windows.Forms.Label();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.SmallGraphicPictureBox = new System.Windows.Forms.PictureBox();
            this.MovieCostTextBox = new System.Windows.Forms.TextBox();
            this.MovieCategoryTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MovieCostLabel = new System.Windows.Forms.Label();
            this.MovieCategoryLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.MovieComboBox = new System.Windows.Forms.ComboBox();
            this.YourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmallGraphicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentMoviesLabel
            // 
            this.CurrentMoviesLabel.AutoSize = true;
            this.CurrentMoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMoviesLabel.Location = new System.Drawing.Point(53, 65);
            this.CurrentMoviesLabel.Name = "CurrentMoviesLabel";
            this.CurrentMoviesLabel.Size = new System.Drawing.Size(137, 24);
            this.CurrentMoviesLabel.TabIndex = 1;
            this.CurrentMoviesLabel.Text = "Current Movies";
            // 
            // PomptLabel
            // 
            this.PomptLabel.AutoSize = true;
            this.PomptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PomptLabel.Location = new System.Drawing.Point(32, 25);
            this.PomptLabel.Name = "PomptLabel";
            this.PomptLabel.Size = new System.Drawing.Size(501, 24);
            this.PomptLabel.TabIndex = 2;
            this.PomptLabel.Text = "Choose the movie you wish to STREAM from the list below";
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Controls.Add(this.SmallGraphicPictureBox);
            this.YourSelectionGroupBox.Controls.Add(this.MovieCostTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.MovieCategoryTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.MovieTitleTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.MovieCostLabel);
            this.YourSelectionGroupBox.Controls.Add(this.MovieCategoryLabel);
            this.YourSelectionGroupBox.Controls.Add(this.MovieTitleLabel);
            this.YourSelectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(260, 92);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(452, 191);
            this.YourSelectionGroupBox.TabIndex = 4;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
            // 
            // SmallGraphicPictureBox
            // 
            this.SmallGraphicPictureBox.BackColor = System.Drawing.Color.White;
            this.SmallGraphicPictureBox.Image = global::COMP123_Programming2_Assignment07.Properties.Resources.companymen;
            this.SmallGraphicPictureBox.Location = new System.Drawing.Point(18, 30);
            this.SmallGraphicPictureBox.Name = "SmallGraphicPictureBox";
            this.SmallGraphicPictureBox.Size = new System.Drawing.Size(127, 150);
            this.SmallGraphicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SmallGraphicPictureBox.TabIndex = 11;
            this.SmallGraphicPictureBox.TabStop = false;
            // 
            // MovieCostTextBox
            // 
            this.MovieCostTextBox.Location = new System.Drawing.Point(330, 150);
            this.MovieCostTextBox.Name = "MovieCostTextBox";
            this.MovieCostTextBox.ReadOnly = true;
            this.MovieCostTextBox.Size = new System.Drawing.Size(94, 29);
            this.MovieCostTextBox.TabIndex = 10;
            // 
            // MovieCategoryTextBox
            // 
            this.MovieCategoryTextBox.Location = new System.Drawing.Point(168, 150);
            this.MovieCategoryTextBox.Name = "MovieCategoryTextBox";
            this.MovieCategoryTextBox.ReadOnly = true;
            this.MovieCategoryTextBox.Size = new System.Drawing.Size(143, 29);
            this.MovieCategoryTextBox.TabIndex = 9;
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(168, 72);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(256, 29);
            this.MovieTitleTextBox.TabIndex = 8;
            // 
            // MovieCostLabel
            // 
            this.MovieCostLabel.AutoSize = true;
            this.MovieCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCostLabel.Location = new System.Drawing.Point(333, 123);
            this.MovieCostLabel.Name = "MovieCostLabel";
            this.MovieCostLabel.Size = new System.Drawing.Size(47, 24);
            this.MovieCostLabel.TabIndex = 7;
            this.MovieCostLabel.Text = "Cost";
            // 
            // MovieCategoryLabel
            // 
            this.MovieCategoryLabel.AutoSize = true;
            this.MovieCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCategoryLabel.Location = new System.Drawing.Point(172, 123);
            this.MovieCategoryLabel.Name = "MovieCategoryLabel";
            this.MovieCategoryLabel.Size = new System.Drawing.Size(85, 24);
            this.MovieCategoryLabel.TabIndex = 6;
            this.MovieCategoryLabel.Text = "Category";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.Location = new System.Drawing.Point(172, 44);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(45, 24);
            this.MovieTitleLabel.TabIndex = 5;
            this.MovieTitleLabel.Text = "Title";
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(621, 341);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(76, 35);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MovieComboBox
            // 
            this.MovieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.MovieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieComboBox.FormattingEnabled = true;
            this.MovieComboBox.Location = new System.Drawing.Point(36, 102);
            this.MovieComboBox.Name = "MovieComboBox";
            this.MovieComboBox.Size = new System.Drawing.Size(196, 252);
            this.MovieComboBox.Sorted = true;
            this.MovieComboBox.TabIndex = 6;
            this.MovieComboBox.SelectedIndexChanged += new System.EventHandler(this.MovieComboBox_SelectedIndexChanged);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 408);
            this.ControlBox = false;
            this.Controls.Add(this.MovieComboBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.YourSelectionGroupBox);
            this.Controls.Add(this.PomptLabel);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Form";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.YourSelectionGroupBox.ResumeLayout(false);
            this.YourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmallGraphicPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentMoviesLabel;
        private System.Windows.Forms.Label PomptLabel;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.PictureBox SmallGraphicPictureBox;
        private System.Windows.Forms.TextBox MovieCostTextBox;
        private System.Windows.Forms.TextBox MovieCategoryTextBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.Label MovieCostLabel;
        private System.Windows.Forms.Label MovieCategoryLabel;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ComboBox MovieComboBox;
    }
}

