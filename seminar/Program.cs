Console.Clear();

Console.Write("Введите целое число: ");
int x = Convert.ToUInt32(Console.ReadLine());
for(int i = 0;i<=x;i++ ){
    Console.WriteLine(Math.Pow(i,2));
}