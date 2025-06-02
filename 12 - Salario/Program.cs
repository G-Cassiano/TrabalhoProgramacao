decimal salarioinicial, salarioaumento, salariofinal;


Console.WriteLine("Digite o salario: ");
salarioinicial = Convert.ToDecimal(Console.ReadLine());

salarioaumento = salarioinicial + (salarioinicial * 15 / 100);

salariofinal = salarioaumento - (salarioaumento * 8 / 100);

Console.WriteLine($"Salario inicial = R${salarioinicial}\nSalario com aumento = R${salarioaumento}\nSalario Final = R${salariofinal}");

