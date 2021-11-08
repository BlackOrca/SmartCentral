using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class PanelData
    {
        [DataMember(Name = "panel")]
        public Panel Panel { get; set; }
    }
}
