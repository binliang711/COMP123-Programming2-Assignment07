/*
 * studentName:Bin Liang | studentNumber:300788322
 * Date last Modified:April 17th,2015
 * Program description:COMP123_Assignment07,Movie Bonanza.
 * Revision	History:
 * 1.13 times revisions(see github)
 * 2.Thanks for Rui.Chuang's supports for passing data between forms.
 * 3.Thanks for Tom Tsiliopoulos's instruction for Programming2.
 */
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
        public OrderForm NextForm;
        //private properties+++++++++++++++++++++++++++++++++++++++++++++++++++
        private Movie _selectedMovie;


        //constructor++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public OrderForm(Movie selectedMovie)//
        {
            InitializeComponent();
            //asign the properties of selectd movie to the order form
            this._selectedMovie = selectedMovie;
            MovieTitleTextBox.Text = selectedMovie.Title;
            MovieCategoryTextBox.Text = selectedMovie.Category;
            LargeGraphicPictureBox.Image = selectedMovie.Picture;
            MovieCostTextBox.Text = "$" + Convert.ToString(selectedMovie.Cost);
            MovieSubTotalTextBox.Text = "$" + Convert.ToString(selectedMovie.Cost);
            MovieSalesTaxTextBox.Text = "$" + Convert.ToString(selectedMovie.Cost * 0.13);
            GrandTotalTextBox.Text = "$" + Convert.ToString(selectedMovie.Cost * 1.13);


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
            StreamForm newStreamForm = new StreamForm();

            //hide the current form
            this.Hide();
            //show the streamForm
            newStreamForm.Owner = this;
            newStreamForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void OrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //the checkBOx is checked, then the AdditionalChargeTextBox become visible
                if (OrderCheckBox.Checked == true)
                {
                    AdditionalChargeLabel.Visible = true;
                    AdditionalChargeTextBox.Visible = true;
                    //add addtional charge to the subtotal and grand total
                    MovieSubTotalTextBox.Text = "$" + Convert.ToString(this._selectedMovie.Cost + 10);
                    GrandTotalTextBox.Text = "$" + Convert.ToString(this._selectedMovie.Cost * 1.13 + 10);
                }
                else if (OrderCheckBox.Checked == false)
                {
                    AdditionalChargeLabel.Visible = false;
                    AdditionalChargeTextBox.Visible = false;

                    //calculate sub and grand total without addtional charge
                    MovieSubTotalTextBox.Text = "$" + Convert.ToString(this._selectedMovie.Cost);
                    GrandTotalTextBox.Text = "$" + Convert.ToString(this._selectedMovie.Cost * 1.13);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }

        }
    }    
}
