using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationProject
{
    class Course
    {
        public int CourseID { get; set; }


        public string Description { get; set; }

        public int Number { get; set; }
        // decided to do this since, all credits will be of full credit and also should never be negative.
        public byte NumberOfCredits { get; set; }

        public string title { get; set; }

        public List<Student> Type { get; set; }

        public Course(int Number, byte NumberOfCredits, string title, string Description) 
        {

            this.Number = Number;
            this.NumberOfCredits = NumberOfCredits;
            this.title = title;
            this.Description = Description;
        }

        public Course(int Number, byte NumberOfCredits, string title) : this(Number,
            NumberOfCredits, title, "No Description Avail")
        {

        }

        



    }
}
