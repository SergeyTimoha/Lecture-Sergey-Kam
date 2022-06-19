Console.Clear();
int numberA = new Random().Next(1, 10); // 1 2 3 4 .. . 9
Console.WriteLine("Введите первое число");
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine("Введите второе число");
Console.WriteLine(numberB);
Console.WriteLine($"Сумма {numberA} + {numberB} = {numberA + numberB}");
