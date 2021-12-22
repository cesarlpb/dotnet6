<<<<<<< HEAD:7-8/Sockets/ClientServer-start/Client/Program.cs
﻿using System;
Client cliente = new Client("localhost", 1025);
cliente.Start();

Console.WriteLine("Escribe el mensaje");
string msg = Console.ReadLine();
cliente.Send(msg);

=======
﻿using System;
Client cliente = new Client("localhost", 1025);
cliente.Start();
while (true){
    Console.WriteLine("Escribe el mensaje");
    string msg = Console.ReadLine();
    cliente.Send(msg);
}
>>>>>>> fb08d3f18fea955960131d86cccb28f53d6cc0d9:7-8-Sockets-Rabbitmq/Sockets/ClientServer-final/Client/Program.cs
Console.ReadKey();