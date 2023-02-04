Console.Clear();
Console.Write("Укажите номер четверти координат : ");
int n=Convert.ToInt32(Console.ReadLine());
if(n==1){
    Console.WriteLine("X>0 && Y>0");
}
else if(n==2){
    Console.WriteLine("X<0 && Y>0");
}
else if(n==3){
    Console.WriteLine("X<0 && Y<0");
}
else if(n==4){
    Console.WriteLine("X>0 && Y<0");
}
else{
    Console.Write("Вы ошиблись!");
}