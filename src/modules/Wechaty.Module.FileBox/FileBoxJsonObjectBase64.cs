using Newtonsoft.Json;

namespace Wechaty.Module.FileBox
{
    public class FileBoxJsonObjectBase64 : FileBoxJsonObject
    {
        [JsonProperty("boxType")]
        public override FileBoxType BoxType => FileBoxType.Base64;

        [JsonProperty("base64")]
        public string Base64 { get; set; }
    }
}