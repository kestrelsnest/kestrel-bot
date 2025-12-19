using Microsoft.Extensions.Configuration;

namespace Kestrel.Bot.Helpers
{
    public static class ConfigurationHelper
    {
        public static string GetStrValue(this IConfiguration section, string value) => section.GetValue<string>(value);
        public static int GetIntValue(this IConfiguration section, string value) => section.GetValue<int>(value);
        public static bool GetBoolValue(this IConfiguration section, string value) => section.GetValue<bool>(value);
    }
}