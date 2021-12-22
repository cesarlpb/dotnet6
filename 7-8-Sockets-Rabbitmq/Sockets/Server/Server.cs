// Server para Socket
public class Server
{
    IPHostEntry host;
    IPAddress ipAddr;
    IPEndPoint endPoint;

    Socket server;
    Socket? client;

    public Server (string ip, int port)
    {
        host = Dns.GetHostEntry(ip);
        ipAddr = host.AddressList[0];
        endPoint = new IPEndPoint(ipAddr, port);

        server = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        server.Bind(endPoint);
        server.Listen(10);
    }
    public void Start()
    {
        byte[] buffer = new byte[1024];
        string message;
        client = server.Accept();

        client.Receive(buffer);
        message = Encoding.ASCII.GetString(buffer);
        Console.WriteLine($"Se recibió el mensaje: {message}");
    }
}
