using System;

class Program
{
  static void Main(string[] args)
  {
    menu();
  }

  static void menu()
  {
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");

    Console.WriteLine("Selecione um Opção: ");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
      case 1: soma(); break;
      case 2: subtracao(); break;
      case 3: divisao(); break;
      case 4: multiplicacao(); break;
      case 5: System.Environment.Exit(0); break;
      default: menu(); break;
    }
  }

  static void soma()
  {
    Console.WriteLine("Digite Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 + v2;
    Console.WriteLine("Resultado da soma é " + resultado);

  }

  static void subtracao()
  {

    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 - v2;

    Console.WriteLine("Resultado da subtração é " + resultado);
  }

  static void divisao()
  {

    Console.WriteLine("Digite o primeiro numero: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo numero: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 / v2;

    Console.WriteLine("O Resultado da divisção é " + resultado);
  }

  static void multiplicacao()
  {

    Console.WriteLine("Digite o primeiro número: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 * v2;

    Console.WriteLine("O resultado da multiplicação é: " + resultado);

  }
}