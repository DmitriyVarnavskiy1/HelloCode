/*
int Factorial(int n)
{
    // 1!=1
    // 0!=1

    if(n==1) return 1;//если н равен 1, значит вернуть 1
    else return n * Factorial(n-1); // иначе вернуть н * на н-1
}

System.Console.WriteLine(Factorial(3)); //1*2*3=6
*/
//------------------------------------------------------------

//Рекурсия и числа Фибоначчи

//f (1)=1
//f (2)=1
//f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n==1||n==2) return 1;
    else return Fibonacci(n-1)+ Fibonacci(n-1);
}

for (int i = 1; i < 10; i++)
{
    System.Console.WriteLine(Fibonacci(i));
}