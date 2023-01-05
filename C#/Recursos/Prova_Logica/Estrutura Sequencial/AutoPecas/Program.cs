// See https://aka.ms/new-console-template for more information


// //dvariaveis
// int cod_p1, cod_p2 ;
// int num_peca1, num_peca2 ;
// decimal valor_uni1, valor_uni2 ;

decimal valorPago;

Console.WriteLine("**********Sistema de AutoPeças***********");
Console.WriteLine("*****************************************");

Console.WriteLine("Informe o codigo da primeira peça: ");
int cod_p1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de peças: ");
int num_peca1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor unitario: ");
decimal valor_uni1= decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe o codigo da segunda peça: ");
int cod_p2 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de peças: ");
int num_peca2 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor unitario: ");
decimal valor_uni2= decimal.Parse(Console.ReadLine());

Console.WriteLine("\n");
valorPago = (num_peca1 * valor_uni1 ) + (num_peca2 * valor_uni2);
Console.WriteLine("VALOR A PAGAR : R$ " + valorPago) ;

Console.WriteLine("clique para encerrar");
Console.ReadKey();
Console.Clear();