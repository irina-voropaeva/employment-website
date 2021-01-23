using System;
using System.Linq;
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

        public StaticDataController(IStaticDataService staticDataService)
        {
            _staticDataService = staticDataService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("supported-languages")]
        public IActionResult GetSupportedLanguages()
        {
            return Ok(Enum.GetValues(typeof(WebsiteLanguage))
                .Cast<WebsiteLanguage>()
                .ToDictionary(t => (int)t, t => t.ToString()));
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("employment-types")]
        public IActionResult GetEmploymentTypes(WebsiteLanguage language)
        {
            return Ok(_staticDataService.GetAllTranslatedEmploymentTypes(language));

        }

    }
}
