using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5-Caracteres e Textos");

        //o char usamos para colocar um caracter 
        //usamos aspas simples '',
        char letra = 'a';
        Console.WriteLine(letra);


        //na tabela CHAR o 65 significa A
        
        letra = (char)65;
        Console.WriteLine(letra);

        //aqui faz uma somatoria de 65 +1, 66 que na tabela é a letra B
        letra = (char)(65 + 1);
        Console.WriteLine(letra);


        //aqui faz uma somatoria de 86 +1= 87  que na tabela é a letra w
        letra = (char)(86 + 1);
        Console.WriteLine(letra);
    }
}