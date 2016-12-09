using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int tamanho;

            palavra = Console.ReadLine();

            Console.WriteLine(palavra[0]);
            Console.WriteLine(palavra[palavra.Length-1]);

            tamanho = palavra.Length;

            if (tamanho % 2 ==0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }

            if ((palavra[0]=='a' ||palavra[0]=='e' || palavra[0]=='i'||palavra[0]=='o'|| palavra[0]=='u')
                && (palavra[palavra.Length - 1] == 'a' || palavra[palavra.Length - 1] == 'e' || palavra[palavra.Length - 1] == 'i' || palavra[palavra.Length - 1] == 'o' || palavra[palavra.Length - 1] == 'u'))
            {
                Console.WriteLine("vogal");
            }
            else
            {
                Console.WriteLine("nao sao vogais");
            }















            Console.ReadKey();

        }
    }
}
