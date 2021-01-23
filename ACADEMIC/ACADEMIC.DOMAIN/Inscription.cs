using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACADEMIC.DOMAIN
{
    public class Inscription
    {
        [Required][Key]
        public int CourseId { get; set; }

        public Course Course { get; set; }

        [Required][Key]
        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}
