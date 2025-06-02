decimal blusas, gasto, novelos;

Console.WriteLine("Quantidade de blusas produzidas: ");
blusas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantidade de novelo usados: ");
novelos = Convert.ToInt32(Console.ReadLine());

gasto = novelos / blusas;

Console.WriteLine($"A Fabrica usou {gasto} novelos de lã por blusas");
