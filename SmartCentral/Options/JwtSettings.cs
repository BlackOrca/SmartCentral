using System;

namespace SmartCentral.Options
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        
        public TimeSpan TokenLifetime { get; set; }
    }
}