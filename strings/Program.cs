using System;

class programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 06 - strings");

        // aqui em alura cursos eu coloquei o espaço antes das aspas para não ficar grudado.
        string primeiraFrase = "Alura cursos ";
        Console.WriteLine(primeiraFrase  +  2023);

        //DIFERENTE DO CHAR, O STRING PODE SER VAZIA 
        string vazia = "";
        Console.WriteLine(vazia);

        //aqui eu posso usar o @ para ficar em cada linha assim consigo fazer uma lista 
        string cursos = @"Cursos disponiveis
    - GOL 
    -C#
    -PYTHON
    -JAVA";
        Console.WriteLine(cursos);
    }
}
