using System.ComponentModel.Design;

Int32 numero1, numero2, numero3, maiorNumero = 0, menorNumero = 0, numeroDoMeio = 0;

Console.WriteLine("Digite o primero número:");
numero1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Digite o segundo número:");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 < numero2 && numero1 < numero3)
{
    menorNumero = numero1;
}
else
{
    if (numero1 > numero2 && numero1 > numero3)
    {
        maiorNumero = numero1;
    }

        if (numero1 > numero2 && numero1 < numero3 || numero1 > numero3 && numero1 < numero2)
        {
            numeroDoMeio = numero1;
        }
    
}


if (numero2 < numero1 && numero2 < numero3)
{
    menorNumero = numero2;
}
else
{
    if (numero2 > numero1 && numero2 > numero3)
    {
        maiorNumero = numero2;
    }

        if (numero2 > numero1 && numero2 < numero3 || numero2 < numero1 && numero2 > numero3)
        {
            numeroDoMeio = numero2;
        }
    
}

if (numero3 < numero1 && numero3 < numero2)
{
    menorNumero = numero3;
}
else
{
    if (numero3 > numero1 && numero3 > numero2)
    {
        maiorNumero = numero3;
    }

        if (numero3 > numero2 && numero3 < numero1 || numero3 > numero1 && numero3 < numero2)
        {
            numeroDoMeio = numero3;
        }
    
}



Console.WriteLine("\n" + maiorNumero + " " + numeroDoMeio + " " + menorNumero );
