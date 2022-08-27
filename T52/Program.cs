//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = new Random().Next(0, 9);
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < 4; i++)
{
    double sum = 0;
    for (int j = 0; j < 3; j++)
    {
        sum += Convert.ToDouble(matrix[j, i]);
    }
    Console.WriteLine("Среденее арифметическое {0} столбца:{1}", i, Math.Round(sum/3, 1));
}


