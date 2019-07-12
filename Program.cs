using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro_teste
{
    class Program
    {
        static string[,] baseDeCarros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarUmCarro();

                if (opcaoMenu == 2)
                    DesalocarUmCarro();

                if (opcaoMenu == 3)
                {
                    MostrarListaDeCarros();
                    Console.Read();
                }

                opcaoMenu = MenuPrincipal();
            }

            Console.ReadKey();
        }
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("         Sistema de alocação de Carros.");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("    Desenvolvido pelas industrias Marte");
            Console.WriteLine("________________________________________________");
        }
        /// <summary>
        /// Metodo que mostra o menu inicial com as opções para escolha.
        /// </summary>
        /// <returns>Retorna o número do menu escolhido.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();
        }

        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um Carro.");
            Console.WriteLine("2 - Devolver um Carro.");
            Console.WriteLine("3 - Listar Carros.");
            Console.WriteLine("4 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        public static void CarregaBaseDeDados()
        {
            baseDeCarros = new string[2, 3]
            {
                {"camaro","2010","sim"},
                {"civic","2010","não"}
            };
        }
        public static bool PesquisaCarroParaAlocacao(string nomeCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarros[i, 0])
                {
                    Console.WriteLine($"O Carro:{nomeCarro}" +
                          $" pode ser alocado?:{baseDeCarros[i, 2]}");

                    return baseDeCarros[i, 2] == "sim";
                }
            }

            return false;
        }
    }
}

