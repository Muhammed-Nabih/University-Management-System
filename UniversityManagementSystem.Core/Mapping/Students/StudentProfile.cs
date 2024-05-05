﻿using AutoMapper;

namespace UniversityManagementSystem.Core.Mapping.Students
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudentListMapping();
            GetStudentByIDMapping();
            AddStudentCommandMapping();
            EditStudentCommandMapping();
            GetStudentPaginationMapping();
        }
    }
}
