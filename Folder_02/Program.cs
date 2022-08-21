//По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("введите число 1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число 2");
int number2 = int.Parse(Console.ReadLine());
int quadro1 = Quadro(number1);
int quadro2 = Quadro(number2);

if (quadro1 == number2 || quadro2 == number1)
{
Console.Write("Да");
}
else 
{
  Console.Write("Нет");  
}

int Quadro (int a)
{
    return a * a;
} 