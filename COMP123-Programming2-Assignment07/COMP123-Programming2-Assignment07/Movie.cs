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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COMP123_Programming2_Assignment07
{
    // MOVIE CLASS
    public class Movie : IComparable<Movie>
    {
        // PRIVATE INSTANCE VARIABLES
        private string _title;
        private string _category;
        private double _cost;
        private Bitmap _picture;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++
        public string Title
        {
            get
            {
                return this._title; // Read-Only
            }
        }
        public string Category
        {
            get
            {
                return this._category; // Read-Only
            }
        }

        public double Cost
        {
            get
            {
                return this._cost; // Read-Only
            }
        }

        public Bitmap Picture
        {
            get
            {
                return this._picture; // Read-Only
            }
        }

        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Movie(string title, string category, double cost, Bitmap picture)
        {
            //Assign values to instance variables
            this._title = title;
            this._category = category;
            this._cost = cost;
            this._picture = picture;
        }


        // PUBLIC METHODS
        // Default comparer for Movie type - compares the title property
        public int CompareTo(Movie compareMovie)
        {
            // A null value means that this object is greater. 
            if (compareMovie == null)
                return 1;

            else
                return this._title.CompareTo(compareMovie._title);
        }
    }
}
