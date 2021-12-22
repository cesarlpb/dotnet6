using System;
Client cliente = new Client("localhost", 1025);
cliente.Start();
cliente.Send("Hola, desde el client.");
Console.ReadKey();