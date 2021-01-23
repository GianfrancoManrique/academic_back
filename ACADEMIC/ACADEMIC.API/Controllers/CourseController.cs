using ACADEMIC.DATA;
using ACADEMIC.DOMAIN;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACADEMIC.API.Controllers
{
    public class CourseController : Controller
    {
        private readonly DatabaseService _academicContext;

        public CourseController(DatabaseService academicContext)
        {
            academicContext = _academicContext;
        }

        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            return await _academicContext.Courses.ToListAsync();
        }
    }
}
