using System.Globalization;
using Newtonsoft.Json;

namespace Infraero.Relprev.CrossCutting.Serializater
{
    public static class SerializerSettings
    {
        public static JsonSerializerSettings GetDefault()
        {
            var jsonSerializerSettings = new JsonSerializerSettings()
            {
                Formatting = Formatting.None,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateParseHandling = DateParseHandling.DateTime,
                Culture = new CultureInfo("pt-BR"),
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Objects
            };

            return jsonSerializerSettings;
        }
    }
}
