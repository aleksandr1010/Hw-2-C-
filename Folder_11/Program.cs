// 14. Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число : ");
int Number = int.Parse(Console.ReadLine());

Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0)Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 100 % 10}");
else Console.WriteLine($"У числа {Number} нет третьей цифры");

Console.WriteLine();