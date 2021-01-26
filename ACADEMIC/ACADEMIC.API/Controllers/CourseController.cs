using ACADEMIC.APPLICATION.Courses.GetCourses;
using ACADEMIC.APPLICATION.Courses.PostCourse;
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
        private readonly IPostCourseCommand _IPostCourseCommand;

        public CourseController(IGetCoursesQuery IGetCoursesQuery, IPostCourseCommand IPostCourseCommand)
        {
            _IGetCoursesQuery = IGetCoursesQuery;
            _IPostCourseCommand = IPostCourseCommand;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCourseModel>>> GetCourses()
        {
            var courses = await _IGetCoursesQuery.Execute();

            return Ok(courses);
        }

        [HttpPost]
        public async Task<ActionResult> PostCourse([FromBody] PostCourseModel model)
        {
            if (model == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var course = await _IPostCourseCommand.Execute(model);

            return StatusCode(201);

        }
    }
}
