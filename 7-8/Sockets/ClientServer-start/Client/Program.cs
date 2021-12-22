using System;
Client cliente = new Client("localhost", 1025);
cliente.Start();

Console.WriteLine("Escribe el mensaje");
string msg = Console.ReadLine();
cliente.Send(msg);

Console.ReadKey();