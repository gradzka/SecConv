﻿using System;
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
        public Socket client { get; set; }
    }
}
