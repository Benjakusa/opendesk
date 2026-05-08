namespace OpenDesk.Domain
{
    public interface ICustomDataProvider
    {
        string GetCustomData(string fieldName);
    }
}