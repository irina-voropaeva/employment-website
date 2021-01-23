using System.Collections.Generic;
using System.ComponentModel;
using KsuEmployment.Services.Dtos;

namespace KsuEmployment.Services.Employment.CvVacancyShared
{
    public class StaticDataService : IStaticDataService
    {
        #region EmploymentTypeDictionaries
        private readonly Dictionary<EmploymentType, string> _employmentTypeEngDict = new Dictionary<EmploymentType, string>()
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

        private readonly Dictionary<EmploymentType, string> _employmentTypeUkrDict = new Dictionary<EmploymentType, string>()
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
                _ => throw new InvalidEnumArgumentException("Not supported EmploymentType value")
            };
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
