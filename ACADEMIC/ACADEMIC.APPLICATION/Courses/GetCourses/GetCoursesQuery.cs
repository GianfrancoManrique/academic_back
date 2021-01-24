using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIC.APPLICATION.Courses.GetCourses
{
    public class GetCoursesQuery : IGetCoursesQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _IMapper;

        public GetCoursesQuery(IDatabaseService databaseService, IMapper Imapper)
        {
            _databaseService = databaseService;
            _IMapper = Imapper;
        }

        public async Task<IEnumerable<GetCourseModel>> Execute()
        {
            var _courses = await _databaseService.Courses.ToListAsync();

            IEnumerable<GetCourseModel> courses= _IMapper.Map<List<GetCourseModel>>(_courses);

            return courses;
        }
    }
}
