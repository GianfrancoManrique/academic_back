using ACADEMIC.APPLICATION.Courses.GetCourses;
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
    [Route("api/[controller]")]
    [ApiController]

    public class CourseController : Controller
    {
        //private readonly DatabaseService _DatabaseService;
        private readonly IGetCoursesQuery _IGetCoursesQuery;

        public CourseController(IGetCoursesQuery IGetCoursesQuery)
        {
            _IGetCoursesQuery = IGetCoursesQuery;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCourseModel>>> GetCourses()
        {
            var courses = await _IGetCoursesQuery.Execute();

            return Ok(courses);
        }
    }
}
