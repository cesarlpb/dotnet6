Client cliente = new Client("localhost", 1025);

string user;
string password;
cliente.Start();
while(true){
    Console.WriteLine("User:");
    user = Console.ReadLine();
    cliente.Send(user);

    Console.WriteLine("Password:");
    password = Console.ReadLine();
    cliente.Send(password);

    Console.WriteLine($"El login se ha realizado con: {cliente.Receive()}");
}

Console.ReadKey();