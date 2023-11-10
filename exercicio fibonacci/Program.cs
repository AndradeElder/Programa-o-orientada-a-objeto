
Console.WriteLine("========================================================");
Console.WriteLine("========================================================");
Console.WriteLine("========= Vamos calcular a sequencia fibonacci ========= \n");
Console.WriteLine("======================================================== \n");

int n1 = 0;
int n2 = 1;
int n3;
int Posição = 2;

Console.WriteLine("Digite a posição de 1 ao 32 que você gostaria de descobrir na sequencia fibonacci: \n");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("O Visual Studio só consegue calcular até esse valor. Depois disso ele quebra os valores.\n");
Console.ForegroundColor = ConsoleColor.White;
var NumDesejado = Convert.ToInt32(Console.ReadLine() + "\n \n");

Console.WriteLine("========== Fibonnaci =========== \n");
Console.WriteLine("Sua sequencia Fibonnacci: \n");

Console.WriteLine("Nº 0" + "     ||     Valor Fibonnacci:   " + "0");
Console.WriteLine("Nº 1" + "     ||     Valor Fibonnacci:   " + "1");

//======================================= Fibonacci Certo =================================

for (int calculo = 1; calculo < NumDesejado; calculo++)
    {
        n3 = n2 + n1;
        n1 = n2;
        n2 = n3;

        Console.WriteLine("Nº " + Posição +"     ||     Valor Fibonnacci:   " + n3);
        Posição++;
    };

Console.WriteLine("======================================================== \n");
Console.WriteLine("Fim do Calculo. Espero ter ajudado. =D");

Console.ReadLine();