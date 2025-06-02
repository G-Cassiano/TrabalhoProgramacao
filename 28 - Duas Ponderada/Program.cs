decimal n1, n2, media;

Console.WriteLine("Digite a 1º Nota");
n1 = Convert.ToDecimal(Console.ReadLine()) * 2;
Console.WriteLine("Digite a 2º Nota");
n2 = Convert.ToDecimal(Console.ReadLine()) * 3;

media = (n1 + n2) / (3 + 2);

Console.WriteLine($"A media ponderada das notas é: {media}");