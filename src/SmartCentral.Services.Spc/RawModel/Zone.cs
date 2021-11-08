using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class Zone
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "type")]
        public ZoneTypes ZoneType { get; set; }
        [DataMember(Name = "zone_name")]
        public string ZoneName { get; set; }
        [DataMember(Name = "area")]
        public int AreaId { get; set; }
        [DataMember(Name = "area_name")]
        public string AreaName { get; set; }
        [DataMember(Name = "input")]
        public ZoneInputs ZoneInput { get; set; }
        [DataMember(Name = "status")]
        public ZoneStatus ZoneStatus { get; set; }
    }
}
