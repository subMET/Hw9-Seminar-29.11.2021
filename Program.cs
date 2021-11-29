int[,] RandomFillMatrix(int[,] matrix, int leftBound, int rightBound)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftBound, rightBound + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int MaxMatrixElement(int[,] matrix)
{
    int max = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max) max = matrix[i, j];
        }
    }
    return max;
}

int SumOfMatrixElements(int[,] matrix)
{
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ = summ + matrix[i, j];
        }
    }
    return summ;
}

// 54. В матрице чисел найти сумму элементов главной диагонали
int SumOfMatrixMainDiagonale(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        System.Console.WriteLine("Матрица не квадратная.");
        return 0;
    }
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ = summ + matrix[i, i];
    }
    return summ;
}

// 54.2. В матрице чисел найти сумму элементов побочной диагонали

int SumOfMatrixSubDiagonale(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        System.Console.WriteLine("Матрица не квадратная.");
        return 0;
    }
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ = summ + matrix[i, matrix.GetLength(0) - 1 - i];
    }
    return summ;
}

// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[] AvgOfColumn(int[,] matrix)
{
    double[] avgD = new double[matrix.GetLength(1)];
    int[] avg = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            avgD[j] = avgD[j] + Convert.ToDouble(matrix[i, j]);
        }
    }
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        avgD[k] = Math.Round(avgD[k] / Convert.ToDouble(matrix.GetLength(1)));
        avg[k] = Convert.ToInt32(avgD[k]);
    }
    return avg;
}

// 56. Написать программу, которая обменивает элементы первой строки и последней строки
void SwitchFirstAndLastStrings(int[,] matrix)
{
    int[] buffer = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        buffer[i] = matrix[0, i];
    }
    int m = matrix.GetLength(0);
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        matrix[0, i] = matrix[m - 1, i];
        matrix[m - 1, i] = buffer[i];
    }
}

// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
void OrderAllStrings(int[,] matrix)
{
    int maxOfString;
    int maxIndex = 0;
    int buffer;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            maxOfString = matrix[i, k];
            maxIndex = k;
            for (int j = k; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > maxOfString)
                {
                    maxOfString = matrix[i, j];
                    maxIndex = j;
                }
            }
            if (maxIndex != k)
            {
                buffer = matrix[i, k];
                matrix[i, k] = matrix[i, maxIndex];
                matrix[i, maxIndex] = buffer;
            }
        }
    }
}

// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить что числа
// столбцов и строк не равны.
int[,] TranspositionOfMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        System.Console.WriteLine("Числа стобцов и строк не равны.");
        return matrix;
    }
    else
    {
        int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrix2[i, j] = matrix[j, i];
            }
        }
        return matrix2;
    }
}


int[,] matrix = new int[5, 5];
matrix = RandomFillMatrix(matrix, 1, 9);
PrintMatrix(matrix);
System.Console.WriteLine();
int sum = SumOfMatrixSubDiagonale(matrix);
System.Console.WriteLine(sum);