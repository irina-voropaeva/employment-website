using System.Collections.Generic;
using System.Threading.Tasks;
using KsuEmployment.Dal.Entities.Employment.CvVacancyShared;

namespace KsuEmployment.Dal.Providers.Employment.CvVacancyShared
{
    public interface IStaticDataProvider
    {
        Task<List<EmploymentType>> GetAll();
    }
}
