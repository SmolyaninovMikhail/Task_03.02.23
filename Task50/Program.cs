// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

Console.Clear();
Console.Write("Введите позицию элемента строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[3, 4];
InputMatrix(matrix);


if (m > matrix.GetLength(0) || n > matrix.GetLength(1))
{
    Console.WriteLine("элемент отсутствует");
}
else
{
    Console.WriteLine($"Значение элемента {m} строки и {n} столбца равно {matrix[m - 1 , n - 1]}");
}
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}