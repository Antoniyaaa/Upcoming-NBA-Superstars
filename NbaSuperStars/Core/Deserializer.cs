using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

using NbaSuperStars.Entities;

namespace NbaSuperStars.Core
{
    public static class Deserializer
    {
        public static List<NbaPlayer> JsonDeserializer(string playersJsonString)
        {
            var serializer = new DataContractJsonSerializer(typeof(List<NbaPlayer>));
            var jsonStringBytes = Encoding.UTF8.GetBytes(playersJsonString);

            using (var stream = new MemoryStream(jsonStringBytes))
            {
                List<NbaPlayer> result = (List<NbaPlayer>)serializer.ReadObject(stream);

                return result;
            }
        }
    }
}
