using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class System
    {
        [DataMember(Name = "time")]
        public string PanelTime { get; set; }
        [DataMember(Name = "engmode")]
        public EngineerModes EngineerMode { get; set; }
        [DataMember(Name = "rf_type")]
        public RfTypes RfType { get; set; }
        [DataMember(Name = "rf_version")]
        public int RfVersion { get; set; }
    }
}
