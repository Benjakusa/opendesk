using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using OpenDesk.Domain.Models.Entities;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Persistance.Common;

namespace OpenDesk.Services
{
    public interface ITicketServiceBase
    {
        IEnumerable<Ticket> GetFilteredTickets(DateTime startDate, DateTime endDate, IList<ITicketExplorerFilter> filters);
        IList<ITicketExplorerFilter> CreateTicketExplorerFilters();
        IEnumerable<Order> GetOrders(int ticketId);
        IEnumerable<OpenTicketData> GetOpenTickets(Expression<Func<Ticket, bool>> prediction);
        IEnumerable<OpenTicketData> GetOpenTickets(int entityId);
        IEnumerable<int> GetOpenTicketIds(int entityId);
        int GetOpenTicketCount();
        void UpdateAccountOfOpenTickets(Entity entity);
        IEnumerable<Ticket> GetTicketsByState(string state);
    }
}
