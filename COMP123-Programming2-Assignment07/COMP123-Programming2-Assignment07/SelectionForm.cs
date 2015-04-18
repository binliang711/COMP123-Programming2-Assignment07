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
    public partial class SelectionForm : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private Bitmap[] _imageArray = { Properties.Resources.seasonofthewitch, Properties.Resources.thedilemma,
                                         Properties.Resources.thegreenhornet,   Properties.Resources.deathrace2, 
                                         Properties.Resources.companymen,       Properties.Resources.nostringsattached, 
                                         Properties.Resources.thewayback,       Properties.Resources.themechanic, 
                                         Properties.Resources.therite,          Properties.Resources.sanctum, 
                                         Properties.Resources.theotherwoman,    Properties.Resources.theroommate, 
                                         Properties.Resources.waitingforever,   Properties.Resources.cedarrapids, 
                                         Properties.Resources.gnomeoandjuliet,  Properties.Resources.justgowithit, 
                                         Properties.Resources.theeagle,         Properties.Resources.iamnumberfour, 
                                         Properties.Resources.footloose,        Properties.Resources.realsteel            };
        
        public SelectionForm PrimaryForm;

        public List<Movie> movies = new List<Movie>();

        // private instance variables
        private int _movieIndex;

        public SelectionForm()
        {
            InitializeComponent();
            InitializeMovieList();
            InitializeMovieComboBox();
        }

        private void InitializeMovieList()
        {
            movies.Add(new Movie("Season of the Witch", "Sci-­‐Fi", 2.99, Properties.Resources.seasonofthewitch));
            movies.Add(new Movie("The Green Hornet", "Action", 2.99, Properties.Resources.thegreenhornet));
            movies.Add(new Movie("The Dilemma", "Comedy", 1.99, Properties.Resources.thedilemma));
            movies.Add(new Movie("Death Race 2", "Action", 2.99, Properties.Resources.deathrace2));
            movies.Add(new Movie("Company Men", "Drama", 1.99, Properties.Resources.companymen));
            movies.Add(new Movie("No Strings Attached", "Comedy", 1.99, Properties.Resources.nostringsattached));
            movies.Add(new Movie("The Way Back", "Drama", 1.99, Properties.Resources.thewayback));
            movies.Add(new Movie("The Mechanic", "Action", 2.99, Properties.Resources.themechanic));
            movies.Add(new Movie("The Rite", "Horror", 2.99, Properties.Resources.therite));
            movies.Add(new Movie("Sanctum", "Action", 2.99, Properties.Resources.sanctum));
            movies.Add(new Movie("The Other Woman", "Action", 2.99, Properties.Resources.theotherwoman));
            movies.Add(new Movie("The Roommate", "Thriller", 2.99, Properties.Resources.theroommate));
            movies.Add(new Movie("Waiting for Forever", "Drama", 1.99, Properties.Resources.waitingforever));
            movies.Add(new Movie("Cedar Rapids", "Comedy", 1.99, Properties.Resources.cedarrapids));
            movies.Add(new Movie("Gnomeo and Juliet", "Family", 0.99, Properties.Resources.gnomeoandjuliet));
            movies.Add(new Movie("Just Go With It", "Comedy", 1.99, Properties.Resources.justgowithit));
            movies.Add(new Movie("The Eagle", "Action", 2.99, Properties.Resources.theeagle));
            movies.Add(new Movie("I am Number Four", "Sci-­‐Fi", 2.99, Properties.Resources.iamnumberfour));
            movies.Add(new Movie("Footloose", "New Release", 4.99, Properties.Resources.footloose));
            movies.Add(new Movie("Real Stee", "New Release", 4.99, Properties.Resources.realsteel));
        }

        private void InitializeMovieComboBox()
        {
            foreach (var movie in movies)
            {
                MovieComboBox.Items.Add(movie.Title);
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm NextForm = new OrderForm(movies[this._movieIndex]);
            this.PrimaryForm = (SelectionForm)ActiveForm;
            this.PrimaryForm.Hide();

            NextForm.Owner = this.PrimaryForm;
            NextForm.Show();
        }

        private void MovieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._movieIndex = MovieComboBox.SelectedIndex;

            movies.Sort();
            MovieTitleTextBox.Text = movies[this._movieIndex].Title;
            MovieCategoryTextBox.Text = movies[this._movieIndex].Category;
            MovieCostTextBox.Text = movies[this._movieIndex].Cost.ToString();
            SmallGraphicPictureBox.Image = this._imageArray[this._movieIndex];
            NextButton.Enabled = true;
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            MovieComboBox.SelectedIndex = 0;

            SmallGraphicPictureBox.Image = this._imageArray[this._movieIndex];
        }

        
    }
}
