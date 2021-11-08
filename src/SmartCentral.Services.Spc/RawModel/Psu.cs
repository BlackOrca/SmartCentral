using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class Psu
    {
        [DataMember(Name = "batt_volt")]
        public string BatteryVoltage { get; set; }
        [DataMember(Name = "aux_volt")]
        public string AuxVoltage { get; set; }
        [DataMember(Name = "aux_curr")]
        public string AuxCurrent { get; set; }
        [DataMember(Name = "ac_freq")]
        public string AcFrequency { get; set; }
    }
}
