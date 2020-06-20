using GG.Common;
using Newtonsoft.Json;

namespace GG.Base
{
    public static class SerializeObject
    {
        public static string SerializeObjectByFieldControl(FieldControl field)
        {
            string json = JsonConvert.SerializeObject(field, Newtonsoft.Json.Formatting.Indented);
            return json;
        }
    }
}
