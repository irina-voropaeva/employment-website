using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KsuEmployment.Dal.Entities.Users;

namespace KsuEmployment.Dal.Entities.Employment.Vacancy
{
    public class Vacancy : BaseNamedEntity
    {
        [ForeignKey("PositionRefId")]
        public Position Position { get; set; }

        public long PositionRefId { get; set; }

        [MaxLength(10000)]
        public string Description { get; set; }

        public double SalaryMin { get; set; }

        public double SalaryMax { get; set; }

        public double? ConcreteSalary { get; set; }

        [ForeignKey("UserRefId")]

        public User User { get; set; }

        public string? UserRefId { get; set; }
    }
}
