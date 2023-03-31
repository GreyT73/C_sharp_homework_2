/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */
System.Console.WriteLine("Enter your 3-digit number: ");
string num = Console.ReadLine();
int first = Convert.ToInt32(num);

if (first > 99 && first < 1000)
{
    int digit1 = first % 100;
    System.Console.WriteLine(digit1 / 10);
}
else
{
System.Console.WriteLine("This isn't a 3-digit number");
}
System.Console.WriteLine("Press Enter");
string anykey = Console.ReadLine();
Console.Clear();
//Следующая задача
System.Console.WriteLine("Enter your number: ");
num = Console.ReadLine();
first = Convert.ToInt32(num);
if (first < 100)
{
    System.Console.WriteLine("Третей цифры нет");
}
else
{
    while (first > 1000)
    {
        first /=10;
    }
    System.Console.WriteLine(first % 10);

}

System.Console.WriteLine("Press Enter");
anykey = Console.ReadLine();
Console.Clear();
// Last task
System.Console.WriteLine("Enter your number: ");
num = Console.ReadLine();
first = Convert.ToInt32(num);
if (first == 6 || first == 7)
{
    System.Console.WriteLine("Holidays!");
}
else if ( first > 0 && first < 6)
{
    System.Console.WriteLine("This isn't holiday :(");
}
else
{
    System.Console.WriteLine("It isn't a day of week");
}