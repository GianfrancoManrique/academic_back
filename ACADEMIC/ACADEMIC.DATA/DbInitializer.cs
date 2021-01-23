using ACADEMIC.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACADEMIC.DATA
{
    public static class DbInitializer
    {
        public static void Seed(DatabaseService academicContext)
        {
            if (!academicContext.Database.EnsureCreated())
            {

                if (!academicContext.Courses.Any())
                {
                    academicContext.AddRange(
                        new Course
                        {
                            Name = "Base Datos desde CERO"
                        }
                    );
                }

                academicContext.SaveChanges();

            }
        }
    }
}
