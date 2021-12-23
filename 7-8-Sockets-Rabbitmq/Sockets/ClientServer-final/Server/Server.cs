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
        host = Dns.GetHostEntry(ip);    // GetHostByNAme esta deprecated
        ipAddr = host.AddressList[0];
        endPoint = new IPEndPoint(ipAddr, port);

        server = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        server.Bind(endPoint);
        server.Listen(10);
    }
    public void Start()
    {
        Thread t;
        while(true){
            Console.WriteLine("Esperando conexión...");
            client = server.Accept();
            t = new Thread(clientConnect);
            t.Start(client);
            Console.WriteLine("Se ha conectado un cliente...");
        }
    }
    public void clientConnect(object obj){
        Socket client = (Socket)obj;
        byte[] buffer;
        string user;
        string password;
        
        while(true){
            buffer = new byte[1024];
            client.Receive(buffer);
            user = Byte2String(buffer);
            
            buffer = new byte[1024];
            client.Receive(buffer);
            password = Byte2String(buffer);

            if(user == "admin" && password == "asdf"){
                byte[] response = Encoding.ASCII.GetBytes("éxito");
                client.Send(response);
            }
            else {
                byte[] response = Encoding.ASCII.GetBytes("Algo ha ido mal...");
                client.Send(response);
            }
        }
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
