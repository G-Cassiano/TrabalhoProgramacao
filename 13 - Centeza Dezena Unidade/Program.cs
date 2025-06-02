int centena, dezena, unidade;

Console.WriteLine("Digite um numero inteiro (ate 3 digitos ");
int numero = Convert.ToInt32(Console.ReadLine());

centena = numero / 100;
dezena = (numero % 100) / 10;
unidade = (numero % 10);

Console.WriteLine($"Centena = {centena}");
Console.WriteLine($"Dezena = {dezena}");
Console.WriteLine($"Unidade = {unidade}");

