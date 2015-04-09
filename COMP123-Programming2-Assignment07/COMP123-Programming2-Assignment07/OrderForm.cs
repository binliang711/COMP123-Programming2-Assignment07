using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Programming2_Assignment07
{
    public partial class OrderForm : Form
    {
        public StreamForm ThirdForm = new StreamForm();
        
        public OrderForm NextForm;
        public OrderForm()
        {
            InitializeComponent();

            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.NextForm = (OrderForm)ActiveForm;
            this.NextForm.Hide();
            this.Owner.Show();
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();

            aboutBox.ShowDialog();
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            this.NextForm = (OrderForm)ActiveForm;
            this.NextForm.Hide();
            this.ThirdForm.Owner = this.NextForm;
            this.ThirdForm.Show();
        }
    }
}
