using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIC.APPLICATION.Courses.GetCourses
{
    public interface IGetCoursesQuery
    {
        public Task<IEnumerable<GetCourseModel>> Execute();
    }
}
