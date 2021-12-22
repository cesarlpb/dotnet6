// Conexión TCP con Clase TcpClient de System.Net.Sockets
using System.Net.Sockets;
using System.Text;
static void Connect(string server, string message){
try {

    int port = 13000;
    TcpClient client = new TcpClient(server, port);

    // El mensaje lo guardamos en un array de bytes
    Byte[] data = Encoding.ASCII.GetBytes(message);

    NetworkStream stream = client.GetStream();
}
}
 

