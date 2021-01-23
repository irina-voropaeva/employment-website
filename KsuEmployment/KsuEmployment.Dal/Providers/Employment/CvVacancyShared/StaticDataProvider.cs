using System.Collections.Generic;
using System.Threading.Tasks;
using KsuEmployment.Dal.Entities.Employment.CvVacancyShared;
using Microsoft.EntityFrameworkCore;

namespace KsuEmployment.Dal.Providers.Employment.CvVacancyShared
{
    public class StaticDataProvider : IStaticDataProvider
    {

        public Task<List<EmploymentType>> GetAll()
        {
            using var context = new KsuEmploymentContext();
            return context.EmploymentTypes.ToListAsync();
        }
    }
}
