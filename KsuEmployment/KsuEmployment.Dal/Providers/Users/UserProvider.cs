using System.Threading.Tasks;
using KsuEmployment.Dal.Entities.Users;

namespace KsuEmployment.Dal.Providers.Users
{
    public class UserProvider : IUserProvider
    {
        public Task CreateUser(User user)
        {
            using var context = new KsuEmploymentContext();
            context.Users.Add(user);

            return context.SaveChangesAsync();
        }
    }
}
