using AutoMapper;
using Cources.DataTransferObjects.Responses;
using Courses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Application.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<Course, CourseSummaryResponse>();

            
        }

    }
}
