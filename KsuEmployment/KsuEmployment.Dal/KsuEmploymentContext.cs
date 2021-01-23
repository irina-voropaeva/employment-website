using KsuEmployment.Dal.Entities.Employment;
using KsuEmployment.Dal.Entities.Employment.CV;
using KsuEmployment.Dal.Entities.Employment.CvVacancyShared;
using KsuEmployment.Dal.Entities.Employment.Vacancy;
using KsuEmployment.Dal.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace KsuEmployment.Dal
{
    public class KsuEmploymentContext : DbContext
    {
        #region CV

        public DbSet<Cv> Cvs { get; set; }
        public DbSet<CvPhone> CvPhones { get; set; }
        public DbSet<CvCategory> CvCategories { get; set; }
        public DbSet<CvCity> CvCity { get; set; }
        public DbSet<CvEmail> CvEmails { get; set; }
        public DbSet<CvCategory> CvSocialNetworks { get; set; }
        public DbSet<SocialNetworkType> SocialNetworkTypes { get; set; }

        #endregion

        #region CvVacancyShared

        public DbSet<Position> Positions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<KnowledgeLevel> KnowledgeLevels { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Skill> Skills { get; set; }

        #endregion

        #region Vacancy

        public DbSet<Vacancy> Vacancies { get; set; }

        #endregion

        #region General

        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        #endregion

        public KsuEmploymentContext()
        {
        }

        public KsuEmploymentContext(DbContextOptions
            <KsuEmploymentContext> options) : base(options)
        {
        }
    }

}