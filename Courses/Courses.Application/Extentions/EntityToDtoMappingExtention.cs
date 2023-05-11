using AutoMapper;
using Courses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Application.Extentions
{
    public static class EntityToDtoMappingExtention
    {
        public static T ConvertToDto<T>(this IEnumerable<Course> course, IMapper mapper)
        {
            return mapper.Map<T>(course);
        }

    }
}
