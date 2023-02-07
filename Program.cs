static void Menu(){
    Console.Clear();
    Console.WriteLine("S = Segundo");
    Console.WriteLine("M = Minuto");
    Console.WriteLine("0 = sair");
    Console.WriteLine("Quanto tempo deseja contar?");

   string data = Console.ReadLine().ToLower();
   char type =char.Parse(data.Substring(data.Length-1, 1));
 int time = int.Parse(data.Substring(0, data.Length-1));

}
static void Start(int time){
    int currentTime=0;

while (currentTime != time)
{
    Console.Clear();
    currentTime++;
    System.Console.WriteLine(currentTime);
    Thread.Sleep(1000);
}
Console.Clear();
System.Console.WriteLine("StropWAtch Finalizado.");
Thread.Sleep(2500);
}


Menu();

//Start(10);