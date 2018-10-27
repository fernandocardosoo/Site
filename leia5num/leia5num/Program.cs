using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leia5num
{
    class Program
    {
        static void Main(string[] args)
        {
            //leia 5 numeros e descubra qual o valor maior e menor entre eles

            int num, i = 0, maior = 0, menor = 99999;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe um numero: ");
                num = int.Parse(Console.ReadLine());

                if (num > maior)
                {
                    maior = num; //variavel armazena o maior valor dentre os lidos
                }
                else
                {
                    if (num < menor)
                    {
                        menor = num; //variavel armazena o menor valor dentre os lidos
                    }
                }

            }
            Console.WriteLine("O maior numero é: " + maior);
            Console.WriteLine("O menor numero é: " + menor);
            Console.ReadKey();
        }
    }
}


