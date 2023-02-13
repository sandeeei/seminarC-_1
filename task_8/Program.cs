// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N>1)
{
    int numberN=2;
    while (numberN<=N)
    {
        Console.Write(numberN + " , ");
        numberN+=2;
    }
}
else
{
    int numberN=0;
    while (numberN>=N)
    {
       Console.Write(numberN + " , ");
        numberN-=2;
    }
}