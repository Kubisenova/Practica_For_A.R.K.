// 1. По двум заданным числам проверять 
// является ли первое квадратом второго

Console.WriteLine("Введите первое число");
string? numLine1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? numLine2 = Console.ReadLine();

if (numLine1 != null && numLine2 != null)
{
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);

    if(num2 * num2 == num1)
    {
        Console.WriteLine("Всё ок, это число является квадратом второго");
        
    }
    else
    {
        Console.WriteLine("Нет, не является квадратом второго");
    }
}