<<<<<<< HEAD:7-8/Sockets/ClientServer-start/Server/Server.cs
﻿// Server para Socket
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
        Console.WriteLine("Esperando conexión...");
        client = server.Accept();
        /*
        Thread t;
        t = new Thread(clientConnect);
        t.Start(client);
        */
        Console.WriteLine("Se ha conectado un cliente...");
        clientConnect();
    }
    public void clientConnect(){
        //Socket client = (Socket)obj;
        byte[] buffer;
        string message;
        

        buffer = new byte[1024];
        client.Receive(buffer);
        message = Encoding.ASCII.GetString(buffer);

        /*
        int len = 0;
        len = message.IndexOf('\0');
        if(len > 0)
            message = message.Substring(0,len);
        */

        Console.WriteLine($"Se recibió el mensaje: {message}");
        //Console.Out.Flush();
    }
}
=======
﻿// Server para Socket
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
        string message;
        int len;
        while(true){
            buffer = new byte[1024];
            client.Receive(buffer);
            message = Encoding.ASCII.GetString(buffer);
            len = message.IndexOf('\0');
            if(len > 0)
                message = message.Substring(0,len);
            Console.WriteLine($"Se recibió el mensaje: {message}");
            Console.Out.Flush();
        }
    }
}
>>>>>>> fb08d3f18fea955960131d86cccb28f53d6cc0d9:7-8-Sockets-Rabbitmq/Sockets/ClientServer-start/Server/Server.cs
