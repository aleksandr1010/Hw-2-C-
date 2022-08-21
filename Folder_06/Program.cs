//Определить количество цифр в числе

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine((int)Math.Log10(num) + 1);
