using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista
{
    class Program
    {
        //Versao 2.0 agora com nome errado
        static void Main(string[] args)
        {
            //iniciando uma lista de string com array linear
            string[] lista = new string[10]; // aqui definimos as posicoes da lista iniciando ela com 10
            //espaços na memoria para alocar informaçoes de texto

            //laço que usamos geralmente para andar sobre as posiçoes da nossa lista
            for (int i = 0; < lista.Length; i++)
            {
                //carregando os valores da nossa lista aqui
                //aonde "i" representa cada espaço que temos disponivel
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                //Datetime e um tipo do net C#  que disponibiliza funções relacionadas a datas
                //e horas, ou seja se precisar trabalhar com essas informaçoes e possivel usar esse cara .
            }

            //laços de repetiçao que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista)//"var item" indica uma unidade da nossa lista "in lista"
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui representamos essa informaçoes na tela

            Console.ReadKey();

        }
    }
}
