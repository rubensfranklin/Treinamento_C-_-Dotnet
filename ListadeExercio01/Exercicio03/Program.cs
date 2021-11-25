using System;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe os valor do Produto 1: ");
        string? produto1 = Console.ReadLine();
        Console.WriteLine("Produto 2: ");
        string? produto2 = Console.ReadLine();
        Console.WriteLine("Produto 3: ");
        string? produto3 = Console.ReadLine();

        double product1 = Convert.ToDouble(produto1);
        double product2 = Convert.ToDouble(produto2);
        double product3 = Convert.ToDouble(produto3);

        if (product1 < product2 && product1 < product3)
        {
            Console.WriteLine("O Melhor custo-benefício  é escolhendo o produto 1.");
        }
        else if (product2 < product1 && product2 < product3)
        {
            Console.WriteLine("O Melhor custo-benefício  é escolhendo o produto 2.");
        }
        else
        {
            Console.WriteLine("O Melhor custo-benefício  é escolhendo o produto 3.");
        }
    }
}