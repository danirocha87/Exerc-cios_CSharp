using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("EXECUTANDO O PROJETO 10- CALCULA POUPANÇA ");

        double investimento = 1000;

        //rendimento de 0,5% (0.005) ao mês

        //faço isso para saber quanto irei ter daqui a um mes 
       // investimento = investimento + investimento * 0.005;

        // //faço isso para saber quanto irei ter daqui a dois meses
        //investimento = investimento + investimento * 0.005;

        // //faço isso para saber quanto irei ter daqui a três meses
        //investimento = investimento + investimento * 0.005;

        //Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(" No mês " + mes + " você tem R$  " + investimento);

            //isso quer dizer mes + 1 ou tambem poderia ser mes ++
            mes +=  1;
        }


    }
}