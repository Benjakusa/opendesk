using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenDesk.Infrastructure.Data;

namespace OpenDesk.Domain.Models.Settings
{
    public class Trigger : EntityClass
    {
        public string Expression { get; set; }
        public DateTime LastTrigger { get; set; }
    }
}
