using System.Collections.Generic;
using System.Threading.Tasks;

namespace KsuEmployment.Services.Employment.Vacancy
{
    public interface IVacancyService
    {
        Task<List<VacancyDto>> GetAll();
    }
}
