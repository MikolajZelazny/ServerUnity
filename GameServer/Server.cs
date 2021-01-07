using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace GameServer
{
    public class Server
    {
        public static int MaxPlayers { get; private set; }
        
        public static int Port { get; private set; };
        
        public static int TcpListener tcpListener;


    }
}