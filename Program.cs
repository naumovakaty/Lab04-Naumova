using System.Globalization;

Console.WriteLine("Hello, World!");
int age = 15;
if (age >= 18) {
    Console.WriteLine("Доступ разрешен");
} else {
    Console.WriteLine("Доступ запрещен");
    Console.WriteLine($"До совершеннолетия осталось ждать: {18 - age}лет");    
}
Console.WriteLine("Программа продолжает работу");
int Age = 14;
if (Age < 13)
{
    Console.WriteLine("Ребёнок");
}
else if (Age < 18)
{
    Console.WriteLine("Подросток");
}
else if (Age < 60)
{
    Console.WriteLine("Взрослый");
}
else
{
    Console.WriteLine("Пенсионер");
}

int age_n = 16;
double height = 1.4;
bool hasParent = true;

if (age_n > 14 && height >= 1.5 || hasParent)
{
    Console.WriteLine("Можно кататься");
} else
{
    Console.WriteLine("Пока нельзя");
}

Console.WriteLine();
Console.WriteLine("Задача A ");

Console.Write("Введите целое число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
string result = (number % 2 == 0) ? "чётное" : "нечётное";

Console.WriteLine($"Число {number} - {result}");

Console.WriteLine();
Console.WriteLine("Задача В");

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"Наибольшее число: {max}");
Console.WriteLine();

Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

Console.WriteLine();
Console.WriteLine("Вариант 2. Проверка возраста для доступа");

Console.Write("Введите ваш возраст: ");
string AgeInput = Console.ReadLine();
input Age = int.Parse(AgeInput);
if (Age >= 18)
{
    Console.WriteLine("Доступ разрешен");
}
else
{
    Console.WriteLine("Доступ запрещен");
}

Console.WriteLine();
Console.WriteLine("Вариант 8. Високосный год и дни февраля");

Console.Write("Введите год: (целое число)");
int year = int.Parse(Console.ReadLine());
if ((year % 4 == 0 && year % 100 != 0) || (year % 100 == 0))
{
    Console.WriteLine($"Год високосный, в феврале 29 дней")ж
}
else
{
    Console.WriteLine($"Год не високосный, в феврале 28 дней");
}
