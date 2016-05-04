// Helpers/Settings.cs

using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace poincer.Helpers
{
    /// <summary>
    ///     This is the Settings static class that can be used in your Core solution or in any
    ///     of your client applications. All settings are laid out the same exact way with getters
    ///     and setters.
    /// </summary>
    public static class Settings
    {
        #region Setting Constants

        private const string CalculatorTypeKey = "calculator_type_key";

        #endregion

        private static ISettings AppSettings => CrossSettings.Current;

        public static CalculatorType CalculatorType
        {
            get { return AppSettings.GetValueOrDefault(CalculatorTypeKey, CalculatorType.Propoints); }
            set { AppSettings.AddOrUpdateValue(CalculatorTypeKey, value); }
        }
    }

    public enum CalculatorType
    {
        Propoints,
        Propoints2
    }
}