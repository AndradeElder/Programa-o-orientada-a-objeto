﻿/*Exericio 1 :

Vamos ver como está o conhecimento Crie um projeto para resolver a sequência de fibonacci 1,1,2,3,5,8,13,21 …
deve pedir o valor a ser calculado 
ex: 5 
resposta: 1,1,2,3,5

Exercicio2
Converter temperatura, deve solicitar a temperatura em celsius e dar a conversão em kelvin e fahrenheit 
ex: 10 
respota : 10 graus celsios são 82 °F e 283.15 Kelvin

 Converter para Fahrenheit (°F): Fórmula: °F = (°C × 9/5) + 32 Converter para Kelvin (K): Fórmula: K = °C + 273.15*/

Console.WriteLine("Vamos calcular a sequencia fibonacci");

var FibonacciNUm = 0;
var FibonacciNDois = 1;

var fibonacciCalculo = FibonacciNUm + FibonacciNDois;

var fibonacciSequencia = fibonacciCalculo+fibonacciCalculo;

Console.WriteLine(fibonacciCalculo);
Console.WriteLine(fibonacciSequencia);

    While (fibonacciSequencia<5)
        {
        fibonacciSequencia = fibonacciCalculo+fibonacciCalculo;
        }


