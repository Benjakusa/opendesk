using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenDesk.Domain.Models.Accounts;

namespace OpenDesk.Presentation.Services
{
    public interface IReportServiceClient
    {
        void PrintAccountScreen(AccountScreen accountScreen);
        void PrintAccountTransactions(Account account,string filter);
    }
}
