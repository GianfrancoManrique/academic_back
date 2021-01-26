using ACADEMIC.DOMAIN;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIC.APPLICATION.Courses.PostCourse
{
    public class PostCourseCommand : IPostCourseCommand
    {
        private readonly IDatabaseService _database;
        private readonly IMapper _IMapper;

        public PostCourseCommand(IDatabaseService database, IMapper IMapper)
        {
            _database = database;
            _IMapper = IMapper;
        }

        public async Task<int> Execute(PostCourseModel model)
        {
            var course= _IMapper.Map<PostCourseModel, Course>(model);

            await _database.Courses.AddAsync(course);
            await _database.SaveAsync();

            return 1;
        }
    }
}
