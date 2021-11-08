using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class Ethernet
    {
        [DataMember(Name = "fitted")]
        public bool Fitted { get; set; }
        [DataMember(Name = "state")]
        public EthernetStates EthernetState { get; set; }
        [DataMember(Name = "dhcp_enabled")]
        public bool DhcpEnabled { get; set; }
        [DataMember(Name = "mac_address")]
        public string MacAdress { get; set; }
        [DataMember(Name = "ip_address")]
        public string IpAdress { get; set; }
        [DataMember(Name = "netmask")]
        public string NetMask { get; set; }
        [DataMember(Name = "gateway")]
        public string Gateway { get; set; }
        [DataMember(Name = "tx_packets")]
        public int TxPackets { get; set; }
        [DataMember(Name = "tx_bytes")]
        public int TxBytes { get; set; }
        [DataMember(Name = "rx_packets")]
        public int RxPackets { get; set; }
        [DataMember(Name = "rx_bytes")]
        public int RxBytes { get; set; }
    }
}
