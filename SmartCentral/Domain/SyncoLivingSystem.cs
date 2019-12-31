namespace SmartCentral.Domain
{
    /// <summary>
    /// Connection to the SyncoLiving System
    /// </summary>
    public class SyncoLivingSystem
    {
        /// <summary>
        /// Id for Database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the SyncoLiving System for identification
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// IP Adress of the SyncoLiving
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
