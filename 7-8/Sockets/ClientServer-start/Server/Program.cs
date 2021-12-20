/*Console.WriteLine("Modo del servidor: ");
Console.WriteLine("1 - una vez");
Console.WriteLine("2 - infinito");
int choice = Convert.ToInt32(Console.ReadLine());

switch(choice){
    case 1:
    InitServer(0);
    break;
    case 2:
    InitServer(1);
    break;
}*/
Server server = new Server("localhost", 1025);
    server.Start();
Console.ReadKey();

void InitServer(int num){

    Server server = new Server("localhost", 1025);
    server.Start();

}