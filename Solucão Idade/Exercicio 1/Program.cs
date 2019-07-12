using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe um nome: "); // writeline escreve informacão e quebra a linha depois.
            var nome = Console.ReadLine(); // ReadLine le uma linha inteira com mais de 1 informaçao

            Console.WriteLine("Informe a idade:");
            int.TryParse(Console.ReadLine(), out int idade);//tryparse espera uma string e depois da virgula para separar
                                                            //o os paramentros temos a saida do valor inserido.
                                                            //colocando "out int" temos a criação da variavel
                                                            //colocando apenas "out precisamos informar uma variavel existente.
            if (idade > 18)
            {
                Console.WriteLine($"Partiu {nome}, beber uhull !!!!");

            }
            else
            {
                Console.WriteLine($"Infelizmente {nome}, voce não tem idade minima");
            }

            Console.ReadKey();
           
        }
        


    }
}
