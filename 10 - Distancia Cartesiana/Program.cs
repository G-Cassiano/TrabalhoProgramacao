double x1, x2, y1, y2, distancia;


Console.WriteLine("Digite o valor de X1: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de Y1: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de X2: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de Y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

distancia = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

Console.WriteLine($"A distancia dos pontos é de: {distancia:F2}");