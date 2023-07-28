using System;

class programa
{
    static void Main(string[] args)
    {
        int idade = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if (idade >= 18 || quantidadePessoas > 1)
        {

            Console.WriteLine("Pode entrar, você é maior de idade");
        }
        else
        {
            Console.WriteLine("Entrada Proibida!");

        }
    }
}
