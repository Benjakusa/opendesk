using OpenDesk.Domain.Models.Menus;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Infrastructure.Data;

namespace OpenDesk.Domain.Models.Settings
{
    public class PrinterMap : ValueClass
    {
        public int PrintJobId { get; set; }
        public string MenuItemGroupCode { get; set; }
        public int MenuItemId { get; set; }
        public int PrinterId { get; set; }
        public int PrinterTemplateId { get; set; }
    }
}
