decimal salariominimo, salario, qsalario;


Console.WriteLine("Digite o valor do Salario Minimo: ");
salariominimo = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o valor do do seu Salario: ");
salario = Convert.ToDecimal(Console.ReadLine());

qsalario = salario / salariominimo;

Console.WriteLine($"Você recebe {qsalario:F2} salarios minimos");