int time =10;
int currentTime=0;

while (currentTime != time)
{
    Console.Clear();
    currentTime++;
    System.Console.WriteLine(currentTime);
    Thread.Sleep(1000);
}