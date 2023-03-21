using System;
using System.Threading;

class Program
{
  static void Main(string[] args)
  {
    menu();
  }

  static void menu()
  {

    Console.Clear();
    Console.WriteLine(" S = Segundos");
    Console.WriteLine(" M = Minutos");
    Console.WriteLine(" 0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if (type == 'm')
    {
      multiplier = 60;
    }

    if (time == 0)
      System.Environment.Exit(0);

    PreStart(time * multiplier);



    //Console.WriteLine(type);
    //Console.WriteLine(time);

  }

  static void PreStart(int time)
  {
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(2500);

    Start(time);

  }

  static void Start(int time)
  {
    //int time = 10;
    int currentTime = 0;

    while (currentTime != time)
    {
      Console.Clear();
      currentTime++;
      Console.WriteLine(currentTime);
      Thread.Sleep(1000);

    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado");
    Thread.Sleep(2500);
    menu();


  }
}