using System.ComponentModel.DataAnnotations;
using OpenDesk.Infrastructure.Data;

namespace OpenDesk.Domain.Models.Settings
{
    public class ProgramSettingValue : EntityClass
    {
        [StringLength(250)]
        public string Value { get; set; }
    }
}
