using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationProject
{
    class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("Course")]
        public string CourseID { get; set; }

        public Student(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }
    }
}
