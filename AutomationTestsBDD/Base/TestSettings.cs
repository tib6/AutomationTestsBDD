namespace AutomationTestsBDD.Base
{
    public class TestSettings
    {
        private static readonly Settings settings;
        static TestSettings()
        {
            settings ??= new Settings();
        }

        public static string baseGoogleURL => settings.GetConfig().Google.baseURL.ToString();

    }
}
