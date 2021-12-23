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
        public string Receive(){
            byte[] buffer = new byte[1024];
            client.Receive(buffer);
            return Byte2String(buffer);
        }
        public string Byte2String(byte[] buffer){
        string message;
        int endIndex;
        
        message = Encoding.ASCII.GetString(buffer);
        endIndex = message.IndexOf('\0');
        if(endIndex>0){
            message = message.Substring(0, endIndex);
        }
        return message;
    }
    }
