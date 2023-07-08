Console.WriteLine("Введите число и нажмите Enter");
int number = int.Parse(Console.ReadLine());
int result = -1;
if (number < 100) {Console.WriteLine("Третьей цифры нет");}
else
{
    while (number > 999)
    {
        number = number /10;
    }
    result = number % 10;
Console.WriteLine($"{number} -> {result}");
}