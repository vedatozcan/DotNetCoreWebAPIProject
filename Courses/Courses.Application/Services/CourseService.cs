using AutoMapper;
using Cources.DataTransferObjects.Responses;
using Courses.Application.Extentions;
using Courses.DataOperations.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CourseSummaryResponse>> GetCoursesAsync()
        {
            var courses = await _repository.GetAllAsync();
            var responses = courses.ConvertToDto<IEnumerable<CourseSummaryResponse>>(_mapper);

            return responses;

            //eğer autoMapper kütüphanesi olmasaydı:
            //var responses = courses.Select(c => new CourseSummaryResponse
            //{
            //    Id = c.Id,
            //    CourseImage = c.CourseImage,
            //    Description = c.Description,
            //    Name = c.Name
            //});

        }
    }
}
