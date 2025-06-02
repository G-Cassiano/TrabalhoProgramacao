Console.WriteLine("Digite a quantidade de frangos na produção: ");
int frangos = Convert.ToInt32(Console.ReadLine());

decimal gasto = frangos * (4.00m + 3.50m * 2);

Console.WriteLine($"O gasto da granja é de R%{gasto}");