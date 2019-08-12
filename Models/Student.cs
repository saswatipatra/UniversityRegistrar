using System.Collections.Generic;
using System;

namespace Registrar.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<CourseStudent>();
        }
        public string Name { get; set; }
        public int StudentId { get; set; }
        //public bool TaskComplete { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<CourseStudent> Courses { get; }


    }
}