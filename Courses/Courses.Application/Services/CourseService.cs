using Cources.DataTransferObjects.Responses;
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

        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<CourceSummaryResponse>> GetCourcesAsync()
        {
            var cource = _repository.GetAllAsync();
            throw new NotImplementedException();
        }
    }
}
