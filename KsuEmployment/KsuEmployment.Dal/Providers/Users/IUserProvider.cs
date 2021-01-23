using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KsuEmployment.Dal.Entities.Users;

namespace KsuEmployment.Dal.Providers.Users
{
    public interface IUserProvider
    {
        Task CreateUser(User user);
    }
}
