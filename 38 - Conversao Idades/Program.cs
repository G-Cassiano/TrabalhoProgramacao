int nascimento, atual, ano, meses, dias, semanas;

Console.WriteLine("Digite o ano de nascimento: ");
nascimento = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o ano atual: ");
atual = Convert.ToInt32(Console.ReadLine());

ano = atual - nascimento;
meses = ano * 12;
dias = ano * 365;
semanas = dias / 7;

Console.WriteLine($"Idade em ano: {ano}\nIdade em meses: {meses}\nIdade em dias: {dias}\nIdade em semanas:{semanas}");