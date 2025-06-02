int numero;

Console.WriteLine("Digite o numer que deseja exibir a tabuada: ");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} = {i} = {numero * i} ");
}
