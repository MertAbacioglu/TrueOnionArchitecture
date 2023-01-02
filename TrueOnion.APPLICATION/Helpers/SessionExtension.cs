using Microsoft.AspNetCore.Http;
using System.Text;
using System.Text.Json;

namespace TrueOnion.APPLICATION.Helpers
{
    public static class SessionExtension
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? Get<T>(this ISession session, string key)
        {
            string? value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }
}
