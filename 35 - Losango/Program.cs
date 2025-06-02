decimal dmaior, dmenor, area;

Console.WriteLine("Use somente VIRGULA para semparar os decimais.");
Console.WriteLine("Digite a diago maior do losango: ");
dmaior = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a diagonal menor do losango: ");
dmenor = Convert.ToDecimal(Console.ReadLine());

area = (dmaior * dmenor) / 2;

Console.WriteLine($"A area do losango é: {area}");