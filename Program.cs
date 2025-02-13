Random rnd = new Random();
int number = rnd.Next(0, 101); 
Console.WriteLine("Давайте сыграем в игру, ваша задачу угадать число от 1 до 100 за 5 попыток!");
Console.WriteLine("Первая попытка, введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a == number)
{
    Console.WriteLine("Поздравляю, вы угадали число с первой попытки!");
}
else if (a > number)
{
    Console.WriteLine("Загаданное число меньше");
    Console.WriteLine("Вторая попытка, введите число");
}
else
{
    Console.WriteLine("Загаданное число больше");
    Console.WriteLine("Вторая попытка, введите число");
}
int  b= Convert.ToInt32(Console.ReadLine());
if (b == number)
{
    Console.WriteLine("Поздравляю, вы угадали число со второй попытки!");
}
else if (b > number)
{
    Console.WriteLine("Загаданное число меньше");
    Console.WriteLine("Третья попытка, введите число");
}
else
{
    Console.WriteLine("Загаданное число больше");
    Console.WriteLine("Третья попытка, введите число");
}
int c = Convert.ToInt32(Console.ReadLine());
if (c == number)
{
    Console.WriteLine("Поздравляю, вы угадали число с третьей попытки!");
}
else if (c > number)
{
    Console.WriteLine("Загаданное число меньше");
    Console.WriteLine("Четвертая попытка, введите число");
}
else
{
    Console.WriteLine("Загаданное число больше");
    Console.WriteLine("Четвертая попытка, введите число");
}
int d = Convert.ToInt32(Console.ReadLine());
if (d == number)
{
    Console.WriteLine("Поздравляю, вы угадали число с четвертой попытки!");
}
else if (d > number)
{
    Console.WriteLine("Загаданное число меньше");
    Console.WriteLine("Пятая попытка, введите число");
}
else
{
    Console.WriteLine("Загаданное число больше");
    Console.WriteLine("Пятая попытка, введите число");
}
int e = Convert.ToInt32(Console.ReadLine());
if (e == number)
{
    Console.WriteLine("Поздравляю, вы угадали число с пятой попытки!");
}
else
{
    Console.WriteLine($"К сожалению вы не смогли угадать загаданное число, это было число: {number}");
}
