using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class Panel
    {
        [DataMember(Name = "type")]
        public string Typ { get; set; }
        [DataMember(Name = "variant")]
        public string Variant { get; set; }
        [DataMember(Name = "version")]
        public string Version { get; set; }
        [DataMember(Name = "device-id")]
        public int DeviceId { get; set; }
        [DataMember(Name = "sn")]
        public string Serialnumber { get; set; }
        [DataMember(Name = "cfgtime")]
        public string ConfigTime { get; set; }
        [DataMember(Name = "hw_ver_major")]
        public int HwVerMajor { get; set; }
        [DataMember(Name = "hw_ver_minor")]
        public int HwVerMinor { get; set; }
        [DataMember(Name = "license_key")]
        public string LicenseKey { get; set; }
    }
}
