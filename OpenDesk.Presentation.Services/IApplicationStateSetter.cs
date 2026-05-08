using System.Collections.Generic;
using OpenDesk.Domain.Models.Entities;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Domain.Models.Users;
using OpenDesk.Presentation.Services.Common;

namespace OpenDesk.Presentation.Services
{
    public interface IApplicationStateSetter
    {
        void SetCurrentLoggedInUser(User user);
        void SetCurrentDepartment(int departmentId);
        void SetCurrentApplicationScreen(AppScreens appScreen);
        EntityScreen SetSelectedEntityScreen(EntityScreen entityScreen);
        void SetApplicationLocked(bool isLocked);
        void SetNumberpadValue(string value);
        void SetCurrentTicketType(TicketType ticketType);
        void SetCurrentTerminal(string terminalName);
        void ResetWorkPeriods();
    }
}