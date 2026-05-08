using System.Collections.Generic;
using OpenDesk.Domain.Models.Users;

namespace OpenDesk.Persistance
{
    public interface IUserDao
    {
        bool GetIsUserExists(string pinCode);
        User GetUserByPinCode(string pinCode);
        IEnumerable<UserRole> GetUserRoles();
    }
}
