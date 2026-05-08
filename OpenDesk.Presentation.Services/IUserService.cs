using System.Collections.Generic;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Domain.Models.Users;
using OpenDesk.Presentation.Services.Common;

namespace OpenDesk.Presentation.Services
{
    public interface IUserService : IPresentationService
    {
        string GetUserName(int userId);
        IEnumerable<Department> PermittedDepartments { get; }
        bool ContainsUser(int userId);
        bool IsDefaultUserConfigured { get; }
        User LoginUser(string pinValue);
        void LogoutUser(bool resetCache = true);
        bool IsUserPermittedFor(string permissionName);
        IEnumerable<UserRole> GetUserRoles();
    }
}
