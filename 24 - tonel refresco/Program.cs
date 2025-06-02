decimal Agua, Suco, Refrescos, Total;


Console.WriteLine("Digite a quantidade de refrescos: ");
Refrescos = Convert.ToDecimal(Console.ReadLine());
Agua = Refrescos * 0.8m;
Suco = Refrescos * 0.2m;

Console.WriteLine($"Será necessario {Agua}L de água mineral e {Suco}L de suco, para fazer {Refrescos} refrescos");