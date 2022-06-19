/*
 * Aplicação exibe o mes de acordo com as opções escolhida pelo usuario;
 * SE a opc  == 1 a aplicação exibe todos os meses;
 * SENÃO SE opc  == 2 a aplicação pergunta qual mes exibir ao usuario;
 
 * Desenvolvedor(a): Luci Sousa
                     19/06/2022



   OBS: Praticando uso dos condicionais IF, ELSE, ELSE IF E SWITCH
        
   SOBRE: Essa aplicação foi desenvolvida usando os condicionais IF, ELSE IF E SWITCH para testes de lógica 
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
    
        int opc; //variavel

        Console.WriteLine("-----------------------------");
        Console.WriteLine("Escolha uma das opções abaixo: ");
        Console.WriteLine("\n");
        Console.WriteLine("1- Exibir todos os meses do ano");
        Console.WriteLine("2- Exibir um mes especifico");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Escolha a opção: ");
        opc = int.Parse(Console.ReadLine());


        if (opc == 1)
        {
            Console.WriteLine("O mês é Janeiro");

            Console.WriteLine("O mês é Fevereiro");

            Console.WriteLine("O mês é Março");

            Console.WriteLine("O mês é Abril");

            Console.WriteLine("O mês é Maio");

            Console.WriteLine("O mês é Junho");

            Console.WriteLine("O mês é Julho");

            Console.WriteLine("O mês é Agosto");

            Console.WriteLine("O mês é Setembro");

            Console.WriteLine("O mês é Outubro");

            Console.WriteLine("O mês é Novembro");

            Console.WriteLine("O mês é Dezembro");

        }
        else if (opc == 2)
        {
            int mes; //variavel
            Console.WriteLine("Qual o mes desejado? ");
            mes = int.Parse(Console.ReadLine());
            
            
            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mês é Janeiro");
                    break;
                case 2:
                    Console.WriteLine("O mês é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mês é Março");
                    break;
                case 4:
                    Console.WriteLine("O mês é Abril");
                    break;
                case 5:
                    Console.WriteLine("O mês é Maio");
                    break;
                case 6:
                    Console.WriteLine("O mês é Junho");
                    break;
                case 7:
                    Console.WriteLine("O mês é Julho");
                    break;
                case 8:
                    Console.WriteLine("O mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("O mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("O mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("O mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("O mês é Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }
        }


        Console.ReadLine();
    }
}