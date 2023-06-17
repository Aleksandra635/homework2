// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

while (true)
{
Console.WriteLine("Введите день недели, где 1 - это пондельник, 2 - вторник, 7 - воскресенье и тд.");
int number = int.Parse(Console.ReadLine());

if (number>0 && number<8)
{
    if (number==1 || number==2 || number==3 || number==4 || number==5)
    {
        Console.WriteLine($"{number} --> нет, это рабочий день");
        break;
    }
    else if (number==6 || number==7)
    {
        Console.WriteLine($"{number} --> да, это выходной день");
        break;
    }
}
else
{
    Console.WriteLine("Ошибка. Введите число от 1 до 7, где 1 - это понедельник, 2 - вторник, 7 - воскресенье и тд.");
}
}