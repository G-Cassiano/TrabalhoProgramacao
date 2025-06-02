decimal lado, area;

Console.WriteLine("Use somente VIRGULA para semparar os decimais.");
Console.WriteLine("Digite o lado do quadrado: ");
lado = Convert.ToDecimal(Console.ReadLine());

area = lado * lado;

Console.WriteLine($"A area do quadrado é: {area}");