using System;

class programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("EXECUTANDO O PROJETO 11- CALCULA POUPANÇA ");


        // int mes = 1;

        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(" No mês " + mes + " você tem R$  " + investimento);

            //isso quer dizer mes + 1 ou tambem poderia ser mes ++
            mes += 1;
        }
        */

        double investimento = 1000;


        for  (int mes = 1; mes <= 12; mes = mes + 1)
        {
            //outra forma de escrever seria  
            //investimento *= 1.005;
            investimento = investimento * 1.005;
            Console.WriteLine(" No mês " + mes + " você tem R$  " + investimento);
        }


    }

}
