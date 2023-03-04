// 0. Вывести квадрат числа
Console.WriteLine("Введите число");
string? numLine = Console.ReadLine();

if (numLine != null)
{
    int number = int.Parse(numLine);

    int outNum = (number*number);
   
    Console.WriteLine(outNum);
    Console.WriteLine("Это квадрат введенного Вами числа ");
}