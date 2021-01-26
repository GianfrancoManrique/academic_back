using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIC.APPLICATION.Courses.PostCourse
{
    public interface IPostCourseCommand
    {
        Task<int> Execute(PostCourseModel model);
    }
}
