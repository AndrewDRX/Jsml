using System;
using System.IO;
using System.Text.Json;

namespace Jsml.Loadables
{
    abstract class AbstractLoadable
    {
        protected JsonObject? Json;
        
        public AbstractLoadable(string path, Type type)
        {
            Json = JsonSerializer.Deserialize(
                json: File.ReadAllText(path: path + "/main.json"),
                returnType: type,
                options: new JsonSerializerOptions {PropertyNameCaseInsensitive = true}
            ) as JsonObject;
        }
        
        protected class JsonObject {}
    }
}
