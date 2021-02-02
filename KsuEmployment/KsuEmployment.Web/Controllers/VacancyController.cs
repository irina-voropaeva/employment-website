using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using KsuEmployment.Services.Employment.Vacancy;
using Microsoft.AspNetCore.Authorization;

namespace KsuEmployment.Web.Controllers
{
    [ApiController]
    [Route("api/vacancies")]
    public class VacancyController : BaseController
    {
        private IVacancyService _vacancyService;
        public VacancyController(IVacancyService vacancyService)
        {
            _vacancyService = vacancyService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("")]
        public async Task<IActionResult> GetVacancies()
        {
            var vacancies = await _vacancyService.GetAll();

            return Ok(vacancies);
        }
    }
}
