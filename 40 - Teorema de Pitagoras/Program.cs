double hipotenusa, catetoA, catetoB;

Console.WriteLine("Digite o valor do primeiro cateto: ");
catetoA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor do segundo cateto: ");
catetoB = Convert.ToDouble(Console.ReadLine());


hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));


Console.WriteLine($"O Valor da hipotenusa é: {hipotenusa:F2}");