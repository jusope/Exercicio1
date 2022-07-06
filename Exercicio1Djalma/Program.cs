using System;

namespace Exercicio1Djalma
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string nome;
            double trabalho, nota1, nota2, media, conceito;

                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.Write("Digite a nota do trabalho: ");
                trabalho = Double.Parse(Console.ReadLine());

                Console.Write("Digite a nota da primeira prova: ");
                nota1 = Double.Parse(Console.ReadLine());

                Console.Write("Digite a nota da segunda prova: ");
                nota2 = Double.Parse(Console.ReadLine());

                media= trabalho + nota1 + nota2;
                conceito = media / 3;

            Console.WriteLine("Média: " + conceito);

            if (conceito >= 8.5)
            {
                Console.Write("Conceito: A");
            }

            else if (conceito >= 7.0)
            {
                Console.Write("Conceito: B");
            }
            else if (conceito >= 6.0)
            {
                Console.Write("Conceito: C");
            }
            else if (conceito >= 0.1)
            {
                Console.Write("Conceito: D");
            }
            else if (conceito <= 0)
            {
                Console.Write("Conceito: E");
            }

            Console.ReadKey();

        }


        }

    }
