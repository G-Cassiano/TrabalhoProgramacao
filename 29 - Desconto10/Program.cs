decimal produto;

Console.WriteLine("Digite o preço do produto: R$");
produto = Convert.ToDecimal(Console.ReadLine());

produto = produto - (produto * 10 / 100);

Console.WriteLine($"O novo valor do produto é: {produto}");