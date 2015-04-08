namespace COMP123_Programming2_Assignment07
{
    partial class StreamForm
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
            this.ThankLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.ChargeNotifyLabel = new System.Windows.Forms.Label();
            this.StreamNotifyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThankLabel
            // 
            this.ThankLabel.AutoSize = true;
            this.ThankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankLabel.Location = new System.Drawing.Point(22, 22);
            this.ThankLabel.Name = "ThankLabel";
            this.ThankLabel.Size = new System.Drawing.Size(348, 24);
            this.ThankLabel.TabIndex = 3;
            this.ThankLabel.Text = "Thank you for choosing Movie Bonanza!";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(137, 163);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(88, 35);
            this.OKButton.TabIndex = 15;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // ChargeNotifyLabel
            // 
            this.ChargeNotifyLabel.AutoSize = true;
            this.ChargeNotifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargeNotifyLabel.Location = new System.Drawing.Point(19, 60);
            this.ChargeNotifyLabel.Name = "ChargeNotifyLabel";
            this.ChargeNotifyLabel.Size = new System.Drawing.Size(353, 24);
            this.ChargeNotifyLabel.TabIndex = 16;
            this.ChargeNotifyLabel.Text = "Your credit cart will be charged[X dollars]";
            // 
            // StreamNotifyLabel
            // 
            this.StreamNotifyLabel.AutoSize = true;
            this.StreamNotifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamNotifyLabel.Location = new System.Drawing.Point(19, 95);
            this.StreamNotifyLabel.Name = "StreamNotifyLabel";
            this.StreamNotifyLabel.Size = new System.Drawing.Size(347, 24);
            this.StreamNotifyLabel.TabIndex = 17;
            this.StreamNotifyLabel.Text = "[Your Movie] will begin streaming shorly!";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 208);
            this.ControlBox = false;
            this.Controls.Add(this.StreamNotifyLabel);
            this.Controls.Add(this.ChargeNotifyLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ThankLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Movie is about to start!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThankLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ChargeNotifyLabel;
        private System.Windows.Forms.Label StreamNotifyLabel;
    }
}