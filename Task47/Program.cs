// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.Clear();
Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Double[,] matrix = new Double[m, n];
InputMatrix(matrix);

void InputMatrix(Double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 101)) / 10;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}