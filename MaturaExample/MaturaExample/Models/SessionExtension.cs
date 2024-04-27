using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace Models;

public static class SessionExtension {

    public static void SetObject<T>(this ISession session, T obj, string key){
        session.SetString(key, JsonSerializer.Serialize(obj));
    }

    public static T? GetObject<T>(this ISession session, string key){
        var val = session.GetString(key);
        return val == null ? default : JsonSerializer.Deserialize<T>(val);
    }

}