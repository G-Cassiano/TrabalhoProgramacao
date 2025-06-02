int CamisaP, CamisaM, CamisaG, TArrecadado;

Console.WriteLine("Digite quantas camisetas pequenas foram compradas: ");
CamisaP = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite quantas camisetas medias foram compradas: ");
CamisaM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite quantas camisetas grandes foram compradas: ");
CamisaG = Convert.ToInt32(Console.ReadLine());

TArrecadado = CamisaG * 15 + CamisaM * 12 + CamisaP * 10;

Console.WriteLine($"Foram vendidas {CamisaP} Camisetas Pequenas, {CamisaM} Camisetas Media, {CamisaG} Camisetas Grandes" +
    $". Arrecandando o total de R${TArrecadado},00");

