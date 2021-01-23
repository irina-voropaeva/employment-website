namespace KsuEmployment.Dal
{
    public class DbInitializer
    {
        public static void Initialize(KsuEmploymentContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
