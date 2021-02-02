namespace KsuEmployment.Services.Employment.Vacancy
{
    public class VacancyDto
    {
        public string PositionName { get; set; }

        public string Description { get; set; }

        public double SalaryMin { get; set; }

        public double SalaryMax { get; set; }

        public double? ConcreteSalary { get; set; }

        public string ContactPersonName { get; set; }

        public long? ContactPersonRefId { get; set; }
    }
}
