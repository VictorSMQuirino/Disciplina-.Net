#region exercício 2 - Tipos de dados inteiros
Console.WriteLine("####### EXERCÍCIO 2 #######\n");
Console.WriteLine("TIPOS DE DADOS NUMÉRICOS INTEIROS:");
Console.WriteLine("\nTipo byte, que varia entre " + byte.MinValue + " e " + byte.MaxValue);
Console.WriteLine("Tipo short byte, que varia entre " + sbyte.MinValue + " e " + sbyte.MaxValue);
Console.WriteLine("Tipo short, que varia entre " + short.MinValue + " e " + short.MaxValue);
Console.WriteLine("Tipo unsigned short, que varia entre " + ushort.MinValue + " e " + ushort.MaxValue);
Console.WriteLine("Tipo int, que varia entre " + int.MinValue + " e " + int.MaxValue);
Console.WriteLine("Tipo unsigned int, que varia entre " + uint.MinValue + " e " + uint.MaxValue);
Console.WriteLine("Tipo long, que varia entre " + long.MinValue + " e " + long.MaxValue);
Console.WriteLine("Tipo unsigned long, que varia entre " + ulong.MinValue + " e " + ulong.MaxValue);
Console.WriteLine("Tipo decimal, que varia entre " + decimal.MinValue + " e " + decimal.MaxValue);

#endregion


#region exercício 3 - Conversão de tipos de dados
Console.WriteLine("\n####### EXERCÍCIO 3 #######\n");
double valorDouble = 25.63;
int valorInteiro = (int) valorDouble;
Console.WriteLine("Parte inteira do valor double = " + valorInteiro);
Console.WriteLine("Ao realizar uma conversão de redução de double para int, ocorre a perda da informação do valor fracionário.");
#endregion

#region exercício 4 - Operadores aritméticos
Console.WriteLine("\n####### EXERCÍCIO 4 #######\n");
int x = 10, y = 3;

Console.WriteLine("Resultado da adição entre x e y = " + (x + y));
Console.WriteLine("Resultado da subtração entre x e y = " + (x - y));
Console.WriteLine("Resultado da multiplicação entre x e y = " + (x * y));
Console.WriteLine("Resultado da divisão entre x e y = " + (x / y));
#endregion

#region exercício 5 - Operadores de comparação
Console.WriteLine("\n####### EXERCÍCIO 5 #######\n");
int a = 5, b = 8;

string resultadoComparacao = a > b ? "maior" : "menor";

Console.WriteLine("a é " + resultadoComparacao + " que b.");
#endregion

#region exercício 6 - Operadores de igualdade
Console.WriteLine("\n####### EXERCÍCIO 6 #######\n");

string str1 = "Hello", str2 = "World";
string resultadoIgualdade = str1 == str2 ? "iguais" : "diferentes";
Console.WriteLine("As strings str1 e str2 são " + resultadoIgualdade);
#endregion