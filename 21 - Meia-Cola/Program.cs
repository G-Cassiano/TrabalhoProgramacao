
int quantidade;
decimal coca350, coca600, coca2, total;


Console.WriteLine("Quantas Meia-Cola 350ml ira comprar: ");
coca350 = Convert.ToInt32(Console.ReadLine()) * 0.350m;
Console.WriteLine("Quantas Meia-Cola 600ml ira comprar: ");
coca600 = Convert.ToInt32(Console.ReadLine()) * 0.600m;
Console.WriteLine("Quantas Meia-Cola 2 Litros ira comprar: ");

coca2 = Convert.ToInt32(Console.ReadLine()) * 2;

total = coca2 + coca350 + coca600;

Console.WriteLine($"O Comerciante comprou {total:F2} Litros de Meia-Cola"); 