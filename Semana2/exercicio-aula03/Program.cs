#region exercício 1
for(int i = 0; i <= 30; i++){
    if(i % 3 == 0 || i % 4 == 0) Console.WriteLine(i);
}
#endregion

#region  exercício 2
int fib1 = 0, fib2 = 1, fib3 = fib1 + fib2;

Console.WriteLine(fib1);
Console.WriteLine(fib2);

do{
    Console.WriteLine(fib3);
    fib1 = fib2;
    fib2 = fib3;
    fib3 = fib1 + fib2;
} while(fib3 < 100);
#endregion

#region exercício 3
for(int i = 1; i <= 8; i++){
    for(int j = 1; j <= i; j++){
        Console.Write(i * j + " ");
    }
    Console.WriteLine();
}
#endregion