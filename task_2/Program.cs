// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue>secondValue)
{
     Console.WriteLine("Первое чиcло " + firstValue + " является наибольшим числом " + secondValue+"  второе число является наименьшим числом  ");
}

else
{
    Console.WriteLine("Второе чиcло " + secondValue + " является наибольшим числом " + firstValue+"  Первое число является наименьшим числом  ");
}