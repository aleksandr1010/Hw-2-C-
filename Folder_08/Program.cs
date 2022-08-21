//Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число:   ");
int n = int.Parse(Console.ReadLine());


int result (int x)
{
    int a = 1;
    for (int i = 1; i <= x; i++)
    {
        a = a * i;
    }
    return a;
}

Console.WriteLine($"Произведение чисел от 1 до {n} равно {result(n)}");
Console.WriteLine();
