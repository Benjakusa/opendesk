using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenDesk.Infrastructure.Data;

namespace OpenDesk.Domain.Models.Menus
{
    public class ProdcutTimerMap : AbstractMap
    {
        public int ProductTimerId { get; set; }
        public string MenuItemGroupCode { get; set; }
        public int MenuItemId { get; set; }
    }
}
