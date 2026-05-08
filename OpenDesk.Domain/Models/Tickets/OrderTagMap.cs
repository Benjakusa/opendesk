using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenDesk.Domain.Models.Menus;
using OpenDesk.Infrastructure.Data;

namespace OpenDesk.Domain.Models.Tickets
{
    public class OrderTagMap : AbstractMap
    {
        public int OrderTagGroupId { get; set; }
        public string MenuItemGroupCode { get; set; }
        public int MenuItemId { get; set; }
    }
}
