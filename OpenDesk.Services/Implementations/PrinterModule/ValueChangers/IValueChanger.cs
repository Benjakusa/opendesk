using System.Collections.Generic;
using OpenDesk.Domain.Models.Settings;

namespace OpenDesk.Services.Implementations.PrinterModule.ValueChangers
{
    interface IValueChanger<in T>
    {
        string Replace(PrinterTemplate template, string content, IEnumerable<T> models);
        string GetValue(PrinterTemplate template, T model);
    }
}
