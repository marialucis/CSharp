

//variaveis
// decimal valorRaio;
// decimal area;

 double pi = 3.14159;

Console.WriteLine("**********Calculando PI***********");
Console.WriteLine("*****************************************");

Console.WriteLine("Infome o valor do raio: ");
decimal valorRaio = double.Parse(Console.ReadLine()); 

decimal area = pi * (valorRaio ^ 2);
Console.WriteLine("Resultado: " +area);


Console.WriteLine("clique para encerrar...");
Console.ReadKey();
Console.Clear();
