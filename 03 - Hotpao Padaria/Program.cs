int QPao, QBroa;
decimal LPaes, LBroa, LTotal, Desconto, TGuardado;

Console.WriteLine("Digite a quantidade de pãos vendidas: ");
QPao = Convert.ToInt32(Console.ReadLine());
LPaes = (QPao * 0.12m);

Console.WriteLine("Digite a quantidade de broas vendidas: ");
QBroa = Convert.ToInt32(Console.ReadLine());
LBroa = (QBroa * 1.50m);

LTotal = (LPaes + LBroa);
Desconto = LTotal * 10 / 100;


Console.WriteLine($"Você arrecadou R${LPaes} com a venda dos pães e R${LBroa} com a venda das broas, " +
$"com o lucro de R${LTotal}, sendo assim é recomendado guardar na poupança R${Desconto}");