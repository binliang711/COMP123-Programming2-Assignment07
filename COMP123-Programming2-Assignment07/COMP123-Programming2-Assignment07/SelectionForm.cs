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
    public partial class SelectionForm : Form
    {
        public OrderForm NextForm = new OrderForm();
        public SelectionForm PrimaryForm;
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.PrimaryForm = (SelectionForm)ActiveForm;
            this.PrimaryForm.Hide();

            this.NextForm.Owner = this.PrimaryForm;
            this.NextForm.Show();
        }
    }
}
