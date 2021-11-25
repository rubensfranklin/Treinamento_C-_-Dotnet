using System;

namespace Exercicio05
{

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Qual o valor da sua hora ");
             double horaT = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Quantas horas trabalhás ");
             double jornada = Convert.ToDouble(Console.ReadLine());
             double sbruto = horaT * jornada;
             double inss = ((10.00/100.00)* sbruto);
             double fgts = ((11.00/100.00)* sbruto);
             double sindicato = ((3.00/100.00)* sbruto);

             if(sbruto < 2000.00)
             {
                 double salarioliquido = sbruto - inss  - sindicato;

                 Console.WriteLine("O seu Salário líquido "+ salarioliquido);
             }
             else if(sbruto <= 5000.00)
             {
                double salarioliquido = sbruto - (sbruto * 0.05) - inss  - sindicato;

                 Console.WriteLine("O seu Salário líquido "+ salarioliquido);
             }

             else if(sbruto <= 7500.00)
             {
                double salarioliquido = sbruto - (sbruto * 0.10) - inss  - sindicato;

                 Console.WriteLine("O seu Salário líquido "+ salarioliquido);
             }

             else 
             {
                double salarioliquido = sbruto - (sbruto * 0.20) - inss  - sindicato;

                 Console.WriteLine("O seu Salário líquido "+ salarioliquido);
             }
        }
    }

}

   