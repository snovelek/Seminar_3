//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Номер четверти: ");
int n= Convert.ToInt32(Console.ReadLine());

if (n>0 && n<5){
    if (n==1) {
    System.Console.WriteLine("Возможные координаты точек - x от 1 до 999");
    System.Console.WriteLine("Возможные координаты точек - y от 1 до 999");
}
if (n==2) {
    System.Console.WriteLine("Возможные координаты точек - x от -999 до -1");
    System.Console.WriteLine("Возможные координаты точек - y от 1 до 999");
}
if (n==3) {
    System.Console.WriteLine("Возможные координаты точек - x от -999 до -1");
    System.Console.WriteLine("Возможные координаты точек - y от -999 до -1");
}
if (n==4) {
    System.Console.WriteLine("Возможные координаты точек - x от 1 до 999");
    System.Console.WriteLine("Возможные координаты точек - y от -999 до -1");
}
}