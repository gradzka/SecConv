using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SecConvServer
{
    class ConnectedClient
    {
        public string login { get; set; }
        public DateTime iAM { get; set; }
        public string addressIP { get; set; }
        //dictionary //login IP
        public Dictionary<string, string> friendWithChangedState {get;set;}
    }
}
