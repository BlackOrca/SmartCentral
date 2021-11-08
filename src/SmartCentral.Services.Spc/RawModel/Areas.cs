using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class Areas
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }
        [DataMember(Name = "data")]
        public AreaData Data { get; set; }
    }
}
