using System.Collections.Generic;
using OpenDesk.Domain.Models.Settings;

namespace OpenDesk.Persistance
{
    public interface IPrinterDao
    {
        IEnumerable<Printer> GetPrinters();
        IEnumerable<PrinterTemplate> GetPrinterTemplates();
    }
}
