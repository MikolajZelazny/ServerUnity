using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace GameServer
{
    public class Client
    {
        public int id;
        public TCP tcp;

        public Client(int _clientId)
        {
            id = _clientId;
            tcp = new TCP();
        }

        public class TCP
        {
            public TcpClient socket;

            private readonly int id;
        }
    }

}