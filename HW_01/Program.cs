// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double[] arrayK = new double[2];
double[] arrayB = new double[2];

for(int i = 0; i < arrayK.Length; i++)
{
   arrayK[i] = new Random().Next(-5, 5);
   arrayB[i] = new Random().Next(-5, 5);
   Console.WriteLine($"K{i+1} = {arrayK[i]}, ");
   Console.WriteLine($"B{i+1} = {arrayB[i]}, ");
}   
Console.WriteLine();

if(arrayK[0] == arrayK[1]) 
Console.WriteLine("Прямые не имеют пересечений");

else
{
    double x = (arrayB[1] - arrayB[0]) / (arrayK[0] - arrayK[1]);
    double y = x * arrayK[0] + arrayB[0];
    Console.WriteLine($"Координаты пересечения: ({x}, {y})");
} 