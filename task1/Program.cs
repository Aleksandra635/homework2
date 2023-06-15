//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
// 782 -> 8
// 918 -> 1

while (true)
{
    Console.WriteLine("Введите трехзначное число:");
    int number = int.Parse(Console.ReadLine());
    if (number < 1000 && number > 99)
    {
        int firstValue = number / 10;
        int secondValue = firstValue % 10;
        Console.WriteLine($"{number} --> {secondValue}");
        break;
    }
    else
     {
     Console.WriteLine("Ошибка.Введите корректное число!");
     }
}


