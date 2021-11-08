using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class Zones
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }
        [DataMember(Name = "data")]
        public ZoneData Data { get; set; }
    }
}
