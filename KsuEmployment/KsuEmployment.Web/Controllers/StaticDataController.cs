using KsuEmployment.Services.Dtos;
using KsuEmployment.Services.Employment.CvVacancyShared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KsuEmployment.Web.Controllers
{
    [Route("api/static-data")]
    public class StaticDataController : BaseController
    {
        private readonly IStaticDataService _staticDataService;
        private const WebsiteLanguage Language = WebsiteLanguage.Ukr;

        public StaticDataController(IStaticDataService staticDataService)
        {
            _staticDataService = staticDataService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("supported-languages")]
        public IActionResult GetSupportedLanguages()
        {
            return Ok(_staticDataService.GetSupportedLanguages());
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("employment-types")]
        public IActionResult GetEmploymentTypes()
        {
            return Ok(_staticDataService.GetAllTranslatedEmploymentTypes(Language));
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("user-roles")]
        public IActionResult GetUserRoles()
        {
            return Ok(_staticDataService.GetUserRoles());
        }
    }
}
