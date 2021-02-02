using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using KsuEmployment.Core;
using KsuEmployment.Services.Dtos;

namespace KsuEmployment.Services.Employment.CvVacancyShared
{
    public class StaticDataService : IStaticDataService
    {
        #region EmploymentTypeDictionaries
        private readonly Dictionary<EmploymentType, string> _employmentTypeEngDict = new()
        {
            {
                EmploymentType.FullTime, "Full-time"
            },
            {
                EmploymentType.PartTime, "Part-time"
            },
            {
                EmploymentType.Casual, "Casual"
            },
            {
                EmploymentType.FixedTerm, "Fixed term"
            },
            {
                EmploymentType.Contract, "Contract"
            },
            {
                EmploymentType.Trainee, "Trainee"
            },
        };

        private readonly Dictionary<EmploymentType, string> _employmentTypeUkrDict = new()
        {
            {
                EmploymentType.FullTime, "Повна зайнятість"
            },
            {
                EmploymentType.PartTime, "Часткова зайнятість"
            },
            {
                EmploymentType.Casual, "Тимчасова зайнятість"
            },
            {
                EmploymentType.FixedTerm, "Фіксований строк"
            },
            {
                EmploymentType.Contract, "Контракт"
            },
            {
                EmploymentType.Trainee, "Стажування"
            },
        };

        #endregion

        public Dictionary<EmploymentType, string> GetAllTranslatedEmploymentTypes(WebsiteLanguage lang)
        {
            return lang switch
            {
                WebsiteLanguage.Eng => _employmentTypeEngDict,
                WebsiteLanguage.Ukr => _employmentTypeUkrDict,
                _ => _employmentTypeEngDict
            };
        }

        private Dictionary<int, string> GetDictionaryConvertedEnum<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .ToDictionary(t => Convert.ToInt32(t), t => t.ToString());
        }

        public Dictionary<int, string> GetSupportedLanguages()
        {
            return GetDictionaryConvertedEnum<WebsiteLanguage>();
        }

        public Dictionary<int, string> GetUserRoles()
        {
            return GetDictionaryConvertedEnum<UserRoles>();
        }
    }

    public enum EmploymentType
    {
        FullTime = 1,
        PartTime = 2,
        Casual = 3,
        FixedTerm = 4,
        Contract = 5,
        Trainee = 6
    }
}
