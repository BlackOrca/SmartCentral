using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class PanelStatus
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }
        [DataMember(Name = "data")]
        public PanelData Data { get; set; }
    }
}
