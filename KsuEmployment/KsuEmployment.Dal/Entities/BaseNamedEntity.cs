using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KsuEmployment.Dal.Entities
{
    public class BaseNamedEntity : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
