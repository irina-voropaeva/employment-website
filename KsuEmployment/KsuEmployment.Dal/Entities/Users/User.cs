using System;
using System.ComponentModel.DataAnnotations;

namespace KsuEmployment.Dal.Entities.Users
{
    public class User : BaseEntity
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string MainPhone { get; set; }
    }
}
