internal class Program
{
    private static void Main(string[] args)
    {
        double temp, fa;

        Console.WriteLine("Informe a temperatura: ");
        temp = double.Parse(Console.ReadLine());

        fa = (temp * 1.8) + 32;

        Console.WriteLine("A temperatura em fahrenheit é: {0}",fa);
    }
}