using ACADEMIC.APPLICATION.Courses.GetCourses;
using ACADEMIC.APPLICATION.Courses.PostCourse;
using ACADEMIC.DOMAIN;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACADEMIC.DATA.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            this.CreateMap<Course,GetCourseModel>();
            this.CreateMap<PostCourseModel,Course>();
        }
    }
}
