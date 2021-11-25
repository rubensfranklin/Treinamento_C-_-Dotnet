using System;

namespace Exercicio06
{
    public class Program
    {

        public static void Main(string[]Args)
        {

            Console.WriteLine("Digite o dia da Semana em formato de numero(de 1 ao 7)");
            int diaDaSemana = Convert.ToInt32(Console.ReadLine());

            switch(diaDaSemana)
            {
                case 1:

                Console.WriteLine("Domingo");
                break;

                case 2:

                Console.WriteLine("Segunda-Feira");
                 break;

                case 3:

                Console.WriteLine("Terça-Feira");
                 break;

                case 4:

                Console.WriteLine("Quarta-Feira");
                 break;

                case 5:

                Console.WriteLine("Quinta-Feira");
                 break;

                case 6:

                Console.WriteLine("Sexta-Feira");
                 break;

                 case 7:

                Console.WriteLine("Sábado");
                 break; 
                 
                 default:
                 Console.WriteLine("Dia da semana inválido");
                 break;


            }
        }
    }
}