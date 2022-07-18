// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите коордитаны 2х точек X и Y");
double[] X = new double[3];
double[] Y = new double[3];
double[] Z = new double[3];

for (int i=0;i<2;i++){
    if (i==0){
        System.Console.WriteLine("Введите координаты первой точки");
    } 
    if (i==1)
    {
        System.Console.WriteLine("Введите координаты второй точки");
    }
    if (i==2)
    {
        System.Console.WriteLine("Введите координаты второй точки");
    }
    System.Console.Write("Введите X = ");
    X[i]=Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите Y = ");
    Y[i]=Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите Z = ");
    Z[i]=Convert.ToDouble(Console.ReadLine());
}
double range=0;
range =Math.Sqrt(Math.Pow(X[1]-X[0],2)+Math.Pow(Y[1]-Y[0],2)+Math.Pow(Z[1]-Z[0],2));

System.Console.WriteLine(Math.Round(range,2));
