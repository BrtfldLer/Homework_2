// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int a = new Random().Next(-1000,1001);
int b = new Random().Next(-1000,1001);
int c = a % b;
Console.WriteLine($"Даны числа {a} и {b}");
Console.WriteLine("Кратно ли первое число второму?");
if (c == 0)
{
    Console.WriteLine($"Число {a} кратно числу {b}");
}
else
{
    Console.WriteLine($"Заданные числа не кратны друг другу, остаток от деления равен {c}");
}
