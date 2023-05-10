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
        IEnumerable<Course> SearchByName(string name);
        IEnumerable<Course> SearchByCategory(int id);

    }
}
