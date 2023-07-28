using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 06 -atribuindo variaveis ");

        int idade = 30;
        int idadeAna = idade;

       Console.WriteLine(idadeAna);

       // isso não pode acontecer porque a idade ja foi declarada la no inicio .
        idade = 25;

    }
}