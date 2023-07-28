using System;

class Programa
{
    static void Main(string[] args)
    {
       Console.WriteLine("Projeto 3 -  Variaveis Ponto Flutuante");

         //double é para numeros com virgula
        double salario;
        salario = 3000.10;

        //o double tambem aceita o tipo inteiro 
        salario = 3000;

        double idade;

        idade = 7.0 / 5;

        Console.WriteLine(idade);




        Console.WriteLine(salario);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
        

        double peso = 4.0;
        int quantidade = 10;
        Console.WriteLine (peso * quantidade);

        int dia = 4;
        int outroDia = 4 + dia;
        Console.WriteLine(outroDia);

        double preco = 5.0;
        double ingresso = 5.0;
        Console.WriteLine(preco *   ingresso);

    }
}