using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACADEMIC.DOMAIN
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required][MaxLength(100)]
        public string Name { get; set; }

        [Required][MaxLength(100)]
        public string LastName { get; set; }

        public bool State { get; set; }

        public List<Inscription> Inscriptions { get; set; }
    }
}
