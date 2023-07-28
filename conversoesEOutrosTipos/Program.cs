using System;

class Programa
{
    static void Main(string[] args)
    {

        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);


        //long consegue armazenar 64bits
        long x;
        x = 2000000000000000000;               
        Console.WriteLine(x);

        //armazena 16bits
        //ort y;
        //= 15000;
        
        short y = 15000;
        Console.WriteLine(y);


        // aqui coloco o f para indicar que é float mesmo.
        //oat altura;
        //tura = 1.55f;

        float altura = 1.55f;
        Console.WriteLine(altura);
        
        Console.WriteLine("Tecle para sair ....");
        Console.ReadLine();
    }
}
