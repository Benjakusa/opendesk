using OpenDesk.Domain.Models.Settings;

namespace OpenDesk.Services.Implementations.PrinterModule
{
    public class TicketPrintTask
    {
        public Printer Printer { get; set; }
        public string[] Lines { get; set; }
    }
}