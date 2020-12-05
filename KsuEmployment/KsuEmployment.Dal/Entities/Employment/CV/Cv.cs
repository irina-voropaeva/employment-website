using System.ComponentModel.DataAnnotations;

namespace KsuEmployment.Dal.Entities.Employment.CV
{
    public class Cv : BaseEntity
    {
        [MaxLength(100)]
        public string Position { get; set; }

        public string CreatedDate { get; set; }
        public string Salary { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
