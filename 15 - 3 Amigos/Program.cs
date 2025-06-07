decimal totalconta, felipe;

Console.WriteLine("O Valor da conte é R$");
totalconta = Convert.ToDecimal(Console.ReadLine());

int carlosandre = (int)(totalconta / 3);
felipe = totalconta - (carlosandre * 2);

Console.WriteLine($"Carlos deve pagar: R${carlosandre}");
Console.WriteLine($"André deve pagar: R${carlosandre}");
Console.WriteLine($"Felipe deve pagar: R${felipe:F2}");
