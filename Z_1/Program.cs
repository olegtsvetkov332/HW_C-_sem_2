//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num < 100) || (num > 999))
{
    Console.Write("Вы ввели не трехзначное число, попробуйте ввести трехзначное число снова: ");
    num = Convert.ToInt32(Console.ReadLine());
}
int secondDigit = ((num / 10) % 10);
Console.Write("Вторая цифра этого числа: ");
Console.Write(secondDigit);