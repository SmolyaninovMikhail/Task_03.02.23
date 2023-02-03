// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

Console.Clear();
Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] neo = new int[m, n];
InputMatrix(neo);


void InputMatrix(int[,] neo)
{
    for (int i = 0; i < neo.GetLength(0); i++)
    {
        for (int j = 0; j < neo.GetLength(1); j++)
        {
            neo[i, j] = new Random().Next(1, 11);
            Console.Write($"{neo[i, j]} \t");
        }
        Console.WriteLine();
    }
}

for (int j = 0; j < neo.GetLength(1); j++)
{
    double trinity = 0;
    for (int i = 0; i < neo.GetLength(0); i++)
    {
        trinity = (trinity + neo[i, j]);
    }
    trinity = trinity / m;
    Console.Write(Math.Round (trinity, 1) + "; " + "\t");
}
Console.WriteLine();