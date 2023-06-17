// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int userInput = int.Parse(Console.ReadLine());
int number = userInput;

while (number > 1000)
{
    number = number/10;
}
if (number < 100)
{
    Console.WriteLine($"{number} --> Третьей цифры нет");
}
else if (number > 99 && number < 1000)
{
    Console.Write($"{userInput} --> {number % 10}");
}



