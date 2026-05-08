using System;

namespace OpenDesk.Services.Common
{
    public interface IProgramSetting
    {
        string StringValue { get; set; }
        DateTime DateTimeValue { get; set; }
        int IntegerValue { get; set; }
        decimal DecimalValue { get; set; }
        bool BoolValue { get; set; }
    }
}