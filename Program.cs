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

if (age_n > 14 && height >= 1.5 || hasParent  )
{
    Console.WriteLine("Можно кататься");
} else
{
    Console.WriteLine("Пока нельзя");
}