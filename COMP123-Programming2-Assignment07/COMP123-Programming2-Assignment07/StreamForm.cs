﻿using System;
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
    public partial class StreamForm : Form
    {
        //private properties+++++++++++++++++++++++++++++++++++++++++++++++++++
        private OrderForm _selectedMovie;

        //constructor++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public StreamForm(OrderForm selectedMovie)
        {
            InitializeComponent();
            //asign the properties of selectd movie to the stream form
            ChargeNotifyTextBox.Text = Convert.ToString(selectedMovie.GrandTotal) ;
            MovieTitleTextBox.Text = Convert.ToString(selectedMovie.MovieTitle);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
