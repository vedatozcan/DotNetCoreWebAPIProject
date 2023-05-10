using Courses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.DataOperations.Repositories
{
    public class EFCourseRepository : ICourseRepository
    {
        public Task Create(Course Entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Course>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Course GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> SearchByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(Course Entity)
        {
            throw new NotImplementedException();
        }
    }
}
