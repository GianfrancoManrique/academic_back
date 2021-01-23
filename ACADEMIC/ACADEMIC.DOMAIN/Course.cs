using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ACADEMIC.DOMAIN
{
    public class Course
    {   
        [Key]
        public int CourseId { get; set; }

        [Required][MaxLength(150)]
        public string Name { get; set; }

        public float ReferencedPrice { get; set; }

        public bool State { get; set; }

        public List<Inscription> Inscriptions { get; set; }
    }
}
