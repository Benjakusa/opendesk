using OpenDesk.Infrastructure.Settings;

namespace OpenDesk.Presentation.Services.Common
{
    public static class AppServices
    {

        public static bool CanStartApplication()
        {
            return LocalSettings.CurrentDbVersion <= 0 || LocalSettings.CurrentDbVersion == LocalSettings.DbVersion;
        }


    }
}
