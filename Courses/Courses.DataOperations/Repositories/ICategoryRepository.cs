using Courses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.DataOperations.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        IEnumerable<Category> SearchByName(string name);
        Category SearchByCourseId(int id);
    }
}
