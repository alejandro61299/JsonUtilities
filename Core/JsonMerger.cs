using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonUtilities.Core;

public static class JsonMerger
{
    public static string Merge(string jsonA, string jsonB)
    {
        JObject jObjectA = JObject.Parse(jsonA);
        JObject jObjectB = JObject.Parse(jsonB);

        jObjectA.Merge(jObjectB,
            new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union
            });

        return JsonConvert.SerializeObject(jObjectA, Formatting.Indented);
    }
}