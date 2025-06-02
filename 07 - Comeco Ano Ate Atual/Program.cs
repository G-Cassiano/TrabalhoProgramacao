int Dia, Mes, DiasMes;

Console.WriteLine("Digite o dia: ");
Dia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o numero do mês que estamos: ");
Mes = Convert.ToInt32(Console.ReadLine());

DiasMes = Mes * 30;
DiasMes += Dia;

Console.WriteLine($"Se passaram {DiasMes} desde o começo do ano");