// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


#region Capacidade e conversão de tipos
int tipoInteiro;
double tipoDouble;
string tipoString;
long tipoLong;

tipoInteiro = int.MaxValue;
tipoLong = long.MaxValue;

tipoLong = tipoInteiro;

tipoString = "100";
tipoInteiro = int.Parse(tipoString);

Console.WriteLine("O máximo inteiro é " + tipoInteiro);
Console.WriteLine("O máximo long é " + tipoLong);

#endregion

#region Operadores
    tipoDouble = tipoInteiro + tipoLong;
    // tipoInteiro =  tipoDouble + tipoLong;
    // tipoLong = tipoDouble + tipoInteiro;

    tipoInteiro = 10 > 5 ? 1 : 0;
#endregion