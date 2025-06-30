using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuserver
{
    public class ServerConfig
    {
        public bool IsAllowAnonymous { get; set; } = false;
        public string SecurityMode { get; set; } = string.Empty;
        public string SecurityPolicy { get; set; } = string.Empty;
    }
}
