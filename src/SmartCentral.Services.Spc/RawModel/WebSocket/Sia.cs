namespace SmartCentral.Services.Spc.RawModel.WebSocket
{
    public class Sia
    {
        public string device_id { get; set; }
        public string timestamp { get; set; }
        public string sia_code { get; set; }
        public string sia_address { get; set; }
        public string description { get; set; }
        public string flags { get; set; }
        public string verification_id { get; set; }
    }
}
