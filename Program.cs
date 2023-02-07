
Menu();


static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo");
    Console.WriteLine("M = Minuto");
    Console.WriteLine("0 = sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if (type == 'm')
        multiplier = 60;

    if (time == 0)
        System.Environment.Exit(0);


    PreStart(time * multiplier);

}

static void PreStart(int time)
{
    Console.Clear();
    System.Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    System.Console.WriteLine("Set...");
    Thread.Sleep(1000);
    System.Console.WriteLine("Go...");
    Thread.Sleep(2500);

    Start(time);
}

static void Start(int time)
{
    int currentTime = time;

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