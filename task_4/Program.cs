// Задача 4: Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdValue = Convert.ToInt32(Console.ReadLine());

if (firstValue>secondValue)
{
    if (firstValue>thirdValue)
    {
        Console.WriteLine("Первое чиcло " + firstValue + " является наибольшим числом ");
    }
    else
    {
         Console.WriteLine("Третье чиcло " + thirdValue + " является наибольшим числом ");
    }
}
else
{
    if (secondValue>thirdValue)
    {
         Console.WriteLine("Второе чиcло " + secondValue + " является наибольшим числом ");
    }
    else
    {
         Console.WriteLine("Третье чиcло " + thirdValue + " является наибольшим числом ");
    }
}