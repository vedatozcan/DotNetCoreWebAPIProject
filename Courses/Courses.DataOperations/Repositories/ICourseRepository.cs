using Courses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.DataOperations.Repositories
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<IEnumerable<Course>> SeachByName(string name);
        Task<IEnumerable<Course>> SeachByCategory(int id);

    }
}
