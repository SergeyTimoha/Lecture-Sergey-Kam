Console.Clear();
//int numberA = new Random().Next(1, 10); // 1 2 3 4 .. . 9
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(numberA);
//int numberB = new Random().Next(1, 10);
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(numberB);
Console.WriteLine($"Сумма {numberA} + {numberB} = {numberA + numberB}");
