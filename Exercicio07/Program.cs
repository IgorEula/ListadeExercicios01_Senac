Int32 numero, cont, calculo = 1;

Console.WriteLine("Digite um número (deve ser positivo e inteiro): ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("0! = 1");
}
else
{
    for (cont = 1; cont <= numero; cont++)
    {
        calculo = calculo * cont;
    }
    Console.WriteLine(numero + "! = " + calculo);
}


