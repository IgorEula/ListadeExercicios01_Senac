decimal valorCarro, quantParcelas, precoFinal, valorAvista, precoParcela;

Console.WriteLine("Digite o valor do veículo: ");
valorCarro = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de parcelas (6x, 12x, 18x, 24x, 30x, 36x, 42x, 48x, 54x, ou 60x):");
quantParcelas = Convert.ToDecimal(Console.ReadLine());

valorAvista = valorCarro - (valorCarro * 0.2m);

Console.WriteLine("\nO valor a vista ficaria: R$" + valorAvista);


switch (quantParcelas)
{
    case 6: precoFinal = valorCarro + (valorCarro * 0.03m);
            precoParcela = precoFinal/6;
        Console.WriteLine("O valor da total do veículo é: R$" + precoFinal);
        Console.WriteLine("O valor da parcela é: R$" + precoParcela);
        break;

    case 12: precoFinal = valorCarro + (valorCarro * 0.06m);
             precoParcela = precoFinal / 12;
        Console.WriteLine("O valor da total do veículo é: R$" + precoFinal);
        Console.WriteLine("O valor da parcela é: R$" + precoParcela);

        break;

    case 18: precoFinal =valorCarro +  (valorCarro * 0.09m);
        precoParcela = precoFinal / 18;
        Console.WriteLine("O valor da total do veículo é: R$" + precoFinal);
        Console.WriteLine("O valor da parcela é: R$" + precoParcela);

        break;

    case 24: precoFinal = valorCarro + (valorCarro * 0.12m);
        precoParcela = precoFinal / 24;
        Console.WriteLine("O valor da total do veículo é: R$" + precoFinal);
        Console.WriteLine("O valor da parcela é: R$" + precoParcela);

        break;

    case 30: precoFinal = valorCarro + (valorCarro * 0.15m);
        precoParcela = precoFinal / 30;
        Console.WriteLine("O valor da total do veículo é: R$" + precoFinal);
        Console.WriteLine("O valor da parcela é: R$" + precoParcela);

        break;

    case 36: precoFinal = valorCarro + (valorCarro * 0.18m);
        precoParcela = precoFinal / 36;
        Console.WriteLine("O valor da total do veículo é: R$" + precoFinal);
        Console.WriteLine("O valor da parcela é: R$" + precoParcela);

        break;

    case 42: precoFinal = valorCarro + (valorCarro * 0.21m);
             precoParcela = precoFinal / 42;
        Console.WriteLine("O valor da total do veículo é: R$" + precoFinal);
        Console.WriteLine("O valor da parcela é: R$" + precoParcela);

        break;

    case 48: precoFinal = valorCarro + (valorCarro * 0.24m);
             precoParcela = precoFinal / 48;
        Console.WriteLine("O valor da total do veículo é: R$" + precoFinal);
        Console.WriteLine("O valor da parcela é: R$" + precoParcela);

        break;

    case 54:
        precoFinal = valorCarro + (valorCarro * 0.27m);
        precoParcela = precoFinal / 54;
        Console.WriteLine("O valor da total do veículo é: R$" + precoFinal);
        Console.WriteLine("O valor da parcela é: R$" + precoParcela);

        break;

    case 60:
        precoFinal = valorCarro + (valorCarro * 0.3m);
        precoParcela = precoFinal / 60;
        Console.WriteLine("O valor da total do veículo é: R$" + precoFinal);
        Console.WriteLine("O valor da parcela é: R$" + precoParcela);

        break;
}

