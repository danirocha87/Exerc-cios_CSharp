using System;

class programa
{
    static void Main(string[] args)
    {
        int idade = 18;
        int quantidadePessoas = 2;

        if (idade >= 18)
        {

            Console.WriteLine("Pode entrar, você é maior de idade");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("ele pode entrar esta acompanhado !");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

        }
    }
}
