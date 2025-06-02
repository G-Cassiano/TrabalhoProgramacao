decimal pesoincial, pesoengordado, pesoemagrecido;

Console.WriteLine("Digite seu peso: ");
pesoincial = Convert.ToDecimal(Console.ReadLine());

pesoengordado = pesoincial + (pesoincial * 15/100);
pesoemagrecido = pesoincial - (pesoincial * 20 / 100);

Console.WriteLine($"Você pesa {pesoincial}kg\nSe você engordar 15% você tera {pesoengordado}Kg\nSe você emagrecer 20% tera {pesoemagrecido}Kg ");