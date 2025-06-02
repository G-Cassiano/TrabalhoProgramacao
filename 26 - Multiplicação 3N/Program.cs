decimal numero, produto = 1;

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Digite o {i}º numero:");
    numero = Convert.ToDecimal(Console.ReadLine());
    produto *= numero;
}
Console.WriteLine($"A mulltiplicação dos numeros é: {produto}");