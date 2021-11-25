using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu salário.");
        string? onda = Console.ReadLine();
        double Onda = Convert.ToDouble(onda);

        if (Onda <= 2800.00)
        {
            double increase = Onda * 0.20;
            Console.WriteLine(" Seu salário atual é  de R$ " + Onda + " terá um acrécimo 20% que é  R$ " + increase);
        }
        else if (Onda <= 7000.00)
        {
            double increase = Onda * 0.15;
            Console.WriteLine("Seu salário atual é  de R$ " + Onda + " terá um acrécimo de 15% que é R$ " + increase);
        }
        else if (Onda <= 15000.00)
        {
            double increase = Onda * 0.10;
            Console.WriteLine("Seu salário atual é  de R$ " + Onda + " terá um acrécimo de 10% que é R$ " + increase);
        }
        else
        {
            double increase = Onda * 0.05;
            Console.WriteLine("Seu salário atual é  de R$ " + Onda + " terá um acrécimo de 5% que é R$ " + increase);
        }
    }
}