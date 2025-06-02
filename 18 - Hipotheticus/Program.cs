int HorasNormal, HorasExtras;
decimal SalarioBruto, SalarioLiquido;

Console.WriteLine("Digite a quantidade de horas NORMAIS trabalhadas: ");
HorasNormal = Convert.ToInt32(Console.ReadLine()) * 10;

Console.WriteLine("Digite a quantidade de horas EXTRAS trabalhadas: ");
HorasExtras = Convert.ToInt32(Console.ReadLine()) * 15;

SalarioBruto = HorasNormal + HorasExtras;
SalarioLiquido = SalarioBruto - (SalarioBruto * 10 / 100);

Console.WriteLine($"O Salario Bruto foi de R${SalarioBruto} e o Liquido foi de R${SalarioLiquido}");