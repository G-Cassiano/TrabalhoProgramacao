decimal Celsius, Fahrenheit;

Console.WriteLine("Digite a temperatura em graus celcius: ");
Celsius = Convert.ToDecimal(Console.ReadLine());

Fahrenheit = Celsius * 1.8m + 32;

Console.WriteLine($"A temperatura em Graus Fahrenheit é: {Fahrenheit}");