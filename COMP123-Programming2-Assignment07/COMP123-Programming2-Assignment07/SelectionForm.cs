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

        public List<Movie> movies = new List<Movie>();

        // private instance variables
        int _movieIndex;

        public SelectionForm()
        {
            InitializeComponent();
            InitializeMovieList();
            InitializeMovieComboBox();
        }

        private void InitializeMovieList()
        {
            movies.Add(new Movie("Season of the Witch", "Sci-Fi", 2.99));
            movies.Add(new Movie("The Dilemma", "Action", 2.99));
            movies.Add(new Movie("The Green Hornet", "Comedy", 1.99));
            movies.Add(new Movie("Death Race 2", "Action", 2.99));
            movies.Add(new Movie("Company Men", "Drama", 1.99));
            movies.Add(new Movie("No Strings Attached", "Comedy", 1.99));
            movies.Add(new Movie("The Way Back", "Drama", 1.99));
            movies.Add(new Movie("The Mechanic", "Action", 2.99));
            movies.Add(new Movie("The Rite", "Horror", 2.99));
            movies.Add(new Movie("Sanctum", "Action", 2.99));
            movies.Add(new Movie("The Other Woman", "Action", 2.99));
            movies.Add(new Movie("The Roommate", "Thriller", 1.99));
            movies.Add(new Movie("Waiting for Forever", "Drama", 1.99));
            movies.Add(new Movie("Cedar Rapids", "Comedy", 1.99));
            movies.Add(new Movie("Gnomeo and Juliet", "Family", 0.99));
            movies.Add(new Movie("Just Go With It", "Comedy", 1.99));
            movies.Add(new Movie("The Eagle", "Action", 2.99));
            movies.Add(new Movie("I am Number Four", "Sci-Fi", 2.99));
            movies.Add(new Movie("Footloose New", "New Release", 4.99));
            movies.Add(new Movie("Real Steel New", "New Release", 4.99));
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
            this.PrimaryForm = (SelectionForm)ActiveForm;
            this.PrimaryForm.Hide();

            this.NextForm.Owner = this.PrimaryForm;
            this.NextForm.Show();
        }

        private void MovieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._movieIndex = MovieComboBox.SelectedIndex;

            movies.Sort();
            MovieTitleTextBox.Text = movies[this._movieIndex].Title;
            MovieCategoryTextBox.Text = movies[this._movieIndex].Category;
            MovieCostTextBox.Text = movies[this._movieIndex].Cost.ToString();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            MovieComboBox.SelectedIndex = 0;
        }
    }
}
