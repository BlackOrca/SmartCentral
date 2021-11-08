using System.Runtime.Serialization;

namespace SmartCentral.Services.Spc.RawModel
{
    [DataContract]
    internal class Area
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "mode")]
        public AreaModes Mode { get; set; }
        [DataMember(Name = "last_set_time")]
        public string LastSetTime { get; set; }
        [DataMember(Name = "last_set_user_id")]
        public int LastSetUserId { get; set; }
        [DataMember(Name = "last_set_user_name")]
        public string LastSetUserName { get; set; }
        [DataMember(Name = "last_unset_time")]
        public string LastUnsetTime { get; set; }
        [DataMember(Name = "last_unset_user_id")]
        public int LastUnsetUserId { get; set; }
        [DataMember(Name = "last_unset_user_name")]
        public string LastUnsetUserName { get; set; }
        [DataMember(Name = "last_alarm")]
        public string LastAlarm{ get; set; }
    }
}
