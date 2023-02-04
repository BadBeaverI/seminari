// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("нет");
else if (n == 2)
    Console.WriteLine("нет");
else if (n == 3)
    Console.WriteLine("нет");
else if (n == 4)
    Console.WriteLine("нет");
else if (n == 5)
    Console.WriteLine("нет");
else if (n == 6)
    Console.WriteLine("Да");
else
    Console.WriteLine("да");