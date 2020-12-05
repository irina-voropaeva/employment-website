using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KsuEmployment.Dal.Entities.Employment.Vacancy
{
    public class Vacancy : BaseNamedEntity
    {
        public Position Position { get; set; }

        [MaxLength(10000)]
        public string Description { get; set; }

        public double SalaryMin { get; set; }
        public double SalaryMax { get; set; }
        public double? ConcreteSalary { get; set; }
    }
}
