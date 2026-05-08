using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenDesk.Infrastructure.Data;

namespace OpenDesk.Domain.Models.Automation
{
    public class Script : EntityClass
    {
        public string HandlerName { get; set; }
        public string Code { get; set; }
    }
}
