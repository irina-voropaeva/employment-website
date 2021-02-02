﻿using System.Collections.Generic;
using KsuEmployment.Services.Dtos;

namespace KsuEmployment.Services.Employment.CvVacancyShared
{
    public interface IStaticDataService
    {
        Dictionary<EmploymentType, string> GetAllTranslatedEmploymentTypes(WebsiteLanguage lang);
        Dictionary<int, string> GetSupportedLanguages();

        Dictionary<int, string> GetUserRoles();
    }
}
