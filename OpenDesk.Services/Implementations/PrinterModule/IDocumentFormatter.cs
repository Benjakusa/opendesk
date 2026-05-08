using System;
using OpenDesk.Domain.Models.Settings;

namespace OpenDesk.Services.Implementations.PrinterModule
{
    public interface IDocumentFormatter
    {
        Type ObjectType { get; }
        string[] GetFormattedDocument(object item, PrinterTemplate printerTemplate);
    }
}