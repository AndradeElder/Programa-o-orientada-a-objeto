/*Calculo de frete para uma compra
Vamos criar um programa que:
receba a distância entre o distribuidor e o local de entrega
calcule o valor do frete
    sendo que para km é cobrado R$ 0,10 
    A cada 200 km, deve adicionar uma taxa de R$ 1,00
    A cada 1000 km, deve adicionar uma taxa de R$ 10,00

Agora precisamos calcular o frete baseado no preço da encomenda
O valor do frete não altera para produtos com até 5kg
Multiplicar o valor do frete para produtos entre 5kg até 25kg em 5x
Multiplicar o valor do frete para produtos entre 25kg até 75kg em 3x*/



Console.WriteLine("Digite o Peso do Frete.");
var PesoFrete = Convert.ToDouble(Console.ReadLine());

var ValorFrete = 10.0f;


if (PesoFrete > 24.9f && PesoFrete < 75.1f)
    {
        ValorFrete * 3;
        Console.WriteLine(ValorFrete);
    };
else if (PesoFrete > 4.9f && PesoFrete < 25.0f)
    {
        ValorFrete * 5;
        Console.WriteLine(ValorFrete);
    };
else if (PesoFrete <0.0f && PesoFrete < 5.0f)
    {
        (ValorFrete)
    }
else
    {
        Console.WriteLine("Nõ conseguimo carregar Pesos acima de 75kg")
    }
