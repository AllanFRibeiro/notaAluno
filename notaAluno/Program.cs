using System;

namespace notaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;
            string sitacao;


            Console.WriteLine("Primeira nota");
            n1 = byte.Parse(Console.ReadLine());

            Console.WriteLine("Segunda nota");
            n2 = byte.Parse(Console.ReadLine());

            Console.WriteLine("terceira nota");
            n3 = byte.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            if (media >= 7)
            {
                sitacao = "Aluno aprovado com média {0}";
            }
            else if (media >= 4)
            {
                sitacao = "Aluno em prova final com média {0}";
            }
            else
            {
                sitacao = "Aluno reprovado com média {0}";
            }

            Console.WriteLine(sitacao, media.ToString("0.00"));


        }
    }
}
