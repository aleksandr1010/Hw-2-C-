//Найти кубы чисел от 1 до N

Console.WriteLine("Введите число :");
int N = int.Parse(Console.ReadLine());
int number = 1;
Console.WriteLine("Ответ :");
while (number <= N)
{
    int cube = number * number * number;
    Console.WriteLine($"{number} ^ 3 = {cube}" );
    number++;
   
}
Console.WriteLine();
