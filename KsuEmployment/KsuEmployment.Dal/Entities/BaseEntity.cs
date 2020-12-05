using System.ComponentModel.DataAnnotations;

namespace KsuEmployment.Dal.Entities
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
