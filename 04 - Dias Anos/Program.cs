Console.WriteLine("Digite o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite a sua idade em anos: ");
int idade = Convert.ToInt32(Console.ReadLine());

int dias = idade * 365;

Console.WriteLine($"{nome} você já viveu {dias} dias!");