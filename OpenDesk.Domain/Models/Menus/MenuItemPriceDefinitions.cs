using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Infrastructure.Data;

namespace OpenDesk.Domain.Models.Menus
{
    public class MenuItemPriceDefinition : EntityClass
    {
        [StringLength(10)]
        public string PriceTag { get; set; }
    }
}
