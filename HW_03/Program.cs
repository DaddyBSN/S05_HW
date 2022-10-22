// Написать программу копирования массива

int[] array = new int[5];
int count = 1;

void FillArray(int[] array)
{
    Console.Write($"Копия № {count}: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i];
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

Console.Write("Введи количество копий массива: ");
int quantity = int.Parse(Console.ReadLine() ?? "0");

while (count <= quantity)
{
    FillArray(array);
    count++;
}