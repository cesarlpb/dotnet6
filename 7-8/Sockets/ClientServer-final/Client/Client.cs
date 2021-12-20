// Cliente para Sockets

using System.Net;
using System.Net.Sockets;
using System.Text;

    public class Client
    {
        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endPoint;

        Socket client;

        public Client(string ip, int port)
        {
            host = Dns.GetHostEntry(ip);
            ipAddr = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddr, port);

            client = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Start()
        {
            client.Connect(endPoint);
        }
        public void Send(string msg)
        {
            byte[] byteMsg = Encoding.ASCII.GetBytes(msg);
            client.Send(byteMsg);
            Console.WriteLine($"Hemos enviado el mensaje: {msg}");
        }
    }
