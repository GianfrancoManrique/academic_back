using ACADEMIC.DOMAIN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIC.APPLICATION
{
    public interface IDatabaseService
    {
        DbSet<Course> Courses { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Inscription> Inscriptions { get; set; }
        Task<int> SaveAsync();
    }
}
