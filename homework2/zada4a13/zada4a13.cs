// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear ();
Console.Write ("Введите не отрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1;
if (n<100)
{
    Console.Write("Третьей цифры нет.");
    n = Convert.ToInt32(Console.ReadLine());
}
if ((n/100)<10)
{
    n1 = n % 100; 
    Console.WriteLine ($"третья цифра числа {n1%10}");  
}
while (n/100>9)
{
    n = n/10;
    if ((n/100)<10)
    {
        n1 = n % 100; 
        Console.WriteLine ($"третья цифра числа:  {n1%10}");  
    }
}
