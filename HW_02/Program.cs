// Написать программу масштабирования фигуры

Console.Write("Координаты вершин фигуры: ");
int[] arrayAxisX = new int[4];
int[] arrayAxisY = new int[4];

for (int i = 0; i < arrayAxisX.Length; i++)
{
    arrayAxisX[i] = new Random().Next(-10, 10);
    arrayAxisY[i] = new Random().Next(-10, 10);
    Console.Write($"{(arrayAxisX[i], arrayAxisY[i])} ");
}
Console.WriteLine();

Console.Write("Введи коофициент: ");
int ratio = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

for (int i = 0; i < arrayAxisX.Length; i++)
{
    arrayAxisX[i] = ratio * arrayAxisX[i];
    arrayAxisY[i] = ratio * arrayAxisY[i];
    Console.Write($"{(arrayAxisX[i], arrayAxisY[i])} ");
}