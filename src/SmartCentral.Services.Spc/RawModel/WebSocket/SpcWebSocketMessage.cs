using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCentral.Services.Spc.RawModel.WebSocket
{
    public class SpcWebSocketMessage
    {
        public string status { get; set; }
        public Data data { get; set; }
    }
}
