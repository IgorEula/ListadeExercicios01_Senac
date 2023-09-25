Int32 valor = 1, cont = 2;
decimal soma = 0;

Console.WriteLine("Digite um número:");
valor = Convert.ToInt32(Console.ReadLine());

while (cont <= valor && valor > 0)
{
    Console.Write("1/" + cont);

    cont++;

    soma = soma + 1 / cont;
}

