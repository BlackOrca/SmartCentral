using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class ZoneData
    {
        [DataMember(Name = "zone")]
        public List<Zone> Zones { get; set; }
    }
}
