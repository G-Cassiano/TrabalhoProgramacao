decimal bmaior, bmenor, altura, area;

Console.WriteLine("Use somente VIRGULA para semparar os decimais.");
Console.WriteLine("Digite a base MAIOR do trapézio: ");
bmaior = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a base MENOR do trapézio: ");
bmenor = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a ALTURA do trapézio: ");
altura = Convert.ToDecimal(Console.ReadLine());

area = ((bmaior + bmenor) * altura) / 2;

Console.WriteLine($"A area do trapézio é: {area}");