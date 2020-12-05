using System;
using System.Collections.Generic;
using System.Text;
using KsuEmployment.Dal.Entities.Employment;
using KsuEmployment.Dal.Entities.Employment.CV;
using KsuEmployment.Dal.Entities.Employment.Vacancy;
using Microsoft.EntityFrameworkCore;

namespace KsuEmployment.Dal
{
    public class KsuEmploymentContext : DbContext
    {
        public DbSet<Cv> Cvs { get; set; }
        public DbSet<CvPhone> CvPhones { get; set; }
        public DbSet<SocialNetworkType> SocialNetworkTypes { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
