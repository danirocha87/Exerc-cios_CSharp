using System;

class programa
{

    static void Main(string[] args)
    {

        // escreva um programa que leia de 0 até 10
        // int contador = 0;

        //while (contador <= 10)
        //  {
        //    Console.WriteLine(contador);
        //  contador += 1;
        //}


        //escreva um laço FOR, que imprima os numeros de 0 até 10.

        //for (int contador = 0; contador <= 10; contador++)
        //{
        //  Console.WriteLine(contador );
        //}
        //Console.ReadLine();




        //exercicio escreva de 1 á 5
        // for (int linha = 0; linha < 5; linha++)
        //{
        //  for (int coluna = 0; coluna < 5; coluna++)
        //{
        //  if (coluna > linha)
        //{
        //  break;
        //}
        //Console.Write(coluna + 1);

        //            }

        //          Console.WriteLine();
        //    }


        //Exercicio - Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.


        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // ou pode fazer de outra forma 
        for (int i = 3; i < 100; i += 3)
        {
            Console.WriteLine(i);



        }
    }
}
