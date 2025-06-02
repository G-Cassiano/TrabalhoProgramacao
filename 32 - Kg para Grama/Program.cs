decimal kg, grama;

Console.WriteLine("Digite o peso da pessoa em KG: (use ponto para separar o KG da Grama) ");
kg = Convert.ToDecimal(Console.ReadLine());

grama = kg * 100;

Console.WriteLine($"A pessoa pesa {grama} gramas");