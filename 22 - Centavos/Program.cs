decimal C1, C5, C10, C25, C50, R1, total;

Console.WriteLine("Diigte a quantidade de moedas de 1 centavos: ");
C1 = Convert.ToDecimal(Console.ReadLine()) * 0.01m;
Console.WriteLine("Diigte a quantidade de moedas de 5 centavos: ");
C5 = Convert.ToDecimal(Console.ReadLine()) * 0.05m;
Console.WriteLine("Diigte a quantidade de moedas de 10 centavos: ");
C10 = Convert.ToDecimal(Console.ReadLine()) * 0.10m;
Console.WriteLine("Diigte a quantidade de moedas de 25 centavos: ");
C25 = Convert.ToDecimal(Console.ReadLine()) * 0.25m;
Console.WriteLine("Diigte a quantidade de moedas de 50 centavos: ");
C50 = Convert.ToDecimal(Console.ReadLine()) * 0.50m;
Console.WriteLine("Diigte a quantidade de moedas de 1 Real: ");
R1 = Convert.ToDecimal(Console.ReadLine()) * 1.00m;

total = C1 + C5 + C10 + C25 + C50 + R1;

Console.WriteLine($"Total economizado: R$ {total}");