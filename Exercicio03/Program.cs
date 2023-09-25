decimal horasTrabalhadasNoMes, valorDaHoraTrabalhada, salarioBruto, iR, 
        descontoSindicato, fgts, salarioLiquido, totalDescontos;

Console.WriteLine("Digite o valor da sua hora trabalhada: ");
valorDaHoraTrabalhada = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a qunatidade de horas trabalhadas no mês: ");
horasTrabalhadasNoMes = Convert.ToDecimal(Console.ReadLine());

salarioBruto = valorDaHoraTrabalhada * horasTrabalhadasNoMes;

descontoSindicato = salarioBruto * 0.03m;

fgts = salarioBruto * 0.11m;

if(salarioBruto > 2500)
{
    iR = salarioBruto * 0.2m;

    totalDescontos = descontoSindicato + iR;

    salarioLiquido = salarioBruto - descontoSindicato - iR;

    Console.WriteLine("\nSalário Bruto: R$ " + salarioBruto +
                      "\n(-) IR (20%):" + "\nR$ " + iR +
                      "\n(-) Sindicato (3%):" + "\nR$ " + descontoSindicato +
                      "\nFGTS (11%): " + "\nR$ " + fgts +
                      "\nTotal de descontos: " + "\nR$ " + totalDescontos +
                      "\nSalário Líquido: " + "\nR$ " + salarioLiquido);
}
else
{
    if(salarioBruto > 900 &&  salarioBruto <= 1500)
    {
        iR = salarioBruto * 0.05m;

        totalDescontos = descontoSindicato + iR;

        salarioLiquido = salarioBruto - descontoSindicato - iR;

        Console.WriteLine("\nSalário Bruto: R$ " + salarioBruto +
                      "\n(-) IR (5%):" + "\nR$ " + iR +
                      "\n(-) Sindicato (3%):" + "\nR$ " + descontoSindicato +
                      "\nFGTS (11%): " + "\nR$ " + fgts +
                      "\nTotal de descontos: " + "\nR$ " + totalDescontos +
                      "\nSalário Líquido: " + "\nR$ " + salarioLiquido);
    }
    if(salarioBruto > 1500 &&  salarioBruto <= 2500)
    {
        iR = (salarioBruto * 0.1m);

        totalDescontos = descontoSindicato + iR;

        salarioLiquido = salarioBruto - descontoSindicato - iR;

        Console.WriteLine("\nSalário Bruto: R$ " + salarioBruto +
                      "\n(-) IR (10%):" + "\nR$ " + iR +
                      "\n(-) Sindicato (3%):" + "\nR$ " + descontoSindicato +
                      "\nFGTS (11%): " + "\nR$ " + fgts +
                      "\nTotal de descontos: " + "\nR$ " + totalDescontos +
                      "\nSalário Líquido: " + "\nR$ " + salarioLiquido);
    }
    if(salarioBruto <= 900)
    {
        iR = 0;

        totalDescontos = descontoSindicato + iR;

        salarioLiquido = salarioBruto - descontoSindicato - iR;

        Console.WriteLine("\nSalário Bruto: R$ " + salarioBruto +
                     "\n(-) IR (Insento%):" + "\nR$ ------ " +
                     "\n(-) Sindicato (3%):" + "\nR$ " + descontoSindicato +
                     "\nFGTS (11%): " + "\nR$ " + fgts +
                     "\nTotal de descontos: " + "\nR$ " + totalDescontos +
                     "\nSalário Líquido: " + "\nR$ " + salarioLiquido);
    }
}


