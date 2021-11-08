using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class AreaData
    {
        [DataMember(Name = "area")]
        public List<Area> Areas { get; set; }
    }
}
