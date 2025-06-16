
Console.WriteLine("Digite a area em metros da frente do terreno: ");
int AFrente = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a area em metros da lateral do terreno: ");
int ALado = Convert.ToInt32(Console.ReadLine());

int ATotal = AFrente * ALado;

Console.WriteLine("A area do terreno é: " + ATotal + "m²");
