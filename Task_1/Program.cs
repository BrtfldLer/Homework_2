// Показать вторую цифру трёхзначного числа
int number = new Random().Next(100,1000);
Console.WriteLine($"Вторая цифра трёхзначного числа {number}");
int a = number % 100;
int b = a / 10;
Console.Write($"равна {b}");
