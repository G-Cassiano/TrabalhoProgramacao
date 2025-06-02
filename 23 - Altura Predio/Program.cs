decimal APessoa, APredio, SombraPessoa, SombraPredio;

Console.WriteLine("Digite sua altura EM METROS? ");
APessoa = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o tamanho da SUA sombra EM METROS? ");
SombraPessoa = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o tamanho da sombra do predio EM METROS? ");
SombraPredio = Convert.ToDecimal(Console.ReadLine());

APredio = (APessoa * SombraPredio) / SombraPessoa;

Console.WriteLine($"A altura do prédio é aproximadamente: {APredio:F2} metros.");