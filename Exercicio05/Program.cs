Int32 ladoQuadrado, cont, i ;

Console.WriteLine("Digite o tamanho do lado do quadrado: ");
ladoQuadrado = Convert.ToInt32(Console.ReadLine());

for(cont = 0; cont < ladoQuadrado; cont++)
{
    for(i = 0; i < ladoQuadrado; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

if (ladoQuadrado < 1 || ladoQuadrado > 20)
{
    Console.WriteLine("Tamanho inválido");

    return;
}