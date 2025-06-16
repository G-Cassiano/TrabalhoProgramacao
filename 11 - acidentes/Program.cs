int tempo, dias , meses , anos, diassobra;

Console.WriteLine("Digite quantos dias estamos sem acidante");
tempo = Convert.ToInt32(Console.ReadLine());

anos = tempo / 360;
diassobra = tempo % 360;
meses = diassobra / 30;
dias = diassobra % 30;


Console.WriteLine($"A empresa está sem acidente a {anos} anos {meses} meses {dias} dias");



