//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("введите цифру дня недели");
int x = int.Parse(Console.ReadLine());

if (x > 0 && x < 6)
{
    Console.Write("Нет");
}

if (x > 5 && x < 8)
{
    Console.Write("Да");
}

if (x < 1 || x > 7)
{
    Console.Write("Ввели не корректный день недели");
} 
