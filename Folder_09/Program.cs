//Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число :");
int N = int.Parse(Console.ReadLine());
int number = 1;
Console.WriteLine("Ответ :");
while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) Console.WriteLine($"{number} ^ 3 = {cube}" );
    number++;
   
}
Console.WriteLine();