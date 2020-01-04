namespace SmartCentral.Contracts.V1.Responses
{
    public class SpcResponse
    {
        /// <summary>
        /// Id for Database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the Alarm System for identification
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// IP Adress of the Api Gateway
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Port of the Apis
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Using HTTPS
        /// </summary>
        public bool UseHttps { get; set; }

        /// <summary>
        /// Api Authentication User
        /// </summary>
        public string ApiUser { get; set; }

        /// <summary>
        /// Api Authentication Password
        /// </summary>
        public string ApiPassword { get; set; }
    }
}
