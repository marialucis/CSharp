using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //declarando variavel
        int contador = 1;

        Console.WriteLine("Executando contagem: ");
        //enquando contador
        while (contador <= 30)
        {
            Console.WriteLine(contador);
            contador++; //incrementando variavel a partir de 1
        }
        Console.ReadLine();
    }
}