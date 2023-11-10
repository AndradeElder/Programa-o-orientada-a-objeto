/*Exericio 1 :

Vamos ver como está o conhecimento Crie um projeto para resolver a sequência de fibonacci 1,1,2,3,5,8,13,21 …
deve pedir o valor a ser calculado 
ex: 5 
resposta: 1,1,2,3,5

Exercicio2
Converter temperatura, deve solicitar a temperatura em celsius e dar a conversão em kelvin e fahrenheit 
ex: 10 
respota : 10 graus celsios são 82 °F e 283.15 Kelvin

 Converter para Fahrenheit (°F): Fórmula: °F = (°C × 9/5) + 32 Converter para Kelvin (K): Fórmula: K = °C + 273.15*/

 /*
    Fibonachi 0,1,1,2,3,5,8,13,21
        5 = 3 + 2           8 = 5 + 3
        3 = 5               5 = 8
        2 = 3               3 = 5             
  */

Console.WriteLine("Vamos calcular a sequencia fibonacci");
Console.WriteLine("==================================== \n");

{ int a = 0;
        int b = 1;
        int soma = 0;
        }

int[] CalculoFibonacci = new int []
    { 
        for (int fibonacci = 0; fibonacci <= 10 ; fibonacci++ )
            {
                soma = b + a;
                b = soma;
                a = b;
            }
    }



Console.WriteLine("fim do teste");