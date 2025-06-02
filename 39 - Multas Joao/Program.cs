decimal salario, C1, C2, multas;

Console.WriteLine("Digite o salario: ");
salario = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o valor da primeira multa (multa de 2% por atraso: ");
C1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o valor da segunda multa (multa de 2% por atraso: ");
C2 = Convert.ToDecimal(Console.ReadLine());


C1 = C1 + C1 * 2 / 100;
C2 = C2 + C2 * 2 / 100;
multas = C1 + C2;
salario -= multas;

Console.WriteLine($"O salário restante após as contas é: R${salario}");