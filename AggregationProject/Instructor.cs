using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationProject
{
    class Instructor
    {
        [Key]
        public int InstructorID { get; set; }


        public string Email { get; set; }
        public string OfficeLocation { get; set; }

        [ForeignKey("Course")] // this should grab the primary key from the course class.
        public int CourseID { get; set; }




    }
}
