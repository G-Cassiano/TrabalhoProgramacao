// Cada lanche = 2x Queijo, 1x presunto, 1x hambuguer
// Queijo = 0,05 = 0.1
// Presunto = 0,05
// Hambuguer = 0,1
decimal queijo, presunto, hamburguer;

Console.WriteLine("Hamburgures feito: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

queijo = 0.1m * quantidade;
presunto = 0.05m * quantidade;
hamburguer = 0.1m * quantidade;

Console.WriteLine($"A quantidade para {quantidade} lanches, é {queijo}Kg de Queijo, {presunto}Kg de Presunto e {hamburguer}Kg de carne");