using Cources.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Application.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<CourceSummaryResponse>> GetCourcesAsync();

    }
}
