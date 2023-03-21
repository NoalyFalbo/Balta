using System.Globalization;
class Program
{

  static void Main(string[] args)
  {
    Console.Write("digite o dado: ");
    var variavel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("digite o segundo dado: ");
    var variavel2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    // var variavel = "N";

    Console.WriteLine("Voce digitou " + variavel + ", e " + variavel2 + ", e o tipo de dado é: ");
    Console.Write(variavel.GetType());

    double soma()
    {
      return variavel + variavel2;
    }

    Console.WriteLine("A soma é: " + soma());


  }
}
