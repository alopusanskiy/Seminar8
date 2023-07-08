int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

int ReadInt(string messege)
{
    System.Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void ChangeMatrix(int[,] arr)
{
    int temp = 0;
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = i + 1; j < arr.GetLength(1); j++)
            {
                if (arr[k, i] < arr[k, j])
                {
                    temp = arr[k, i];
                    arr[k, i] = arr[k, j];
                    arr[k, j] = temp;
                }
            }
        }
    }
}


int row = ReadInt("Введите количество столбцов: ");
int col = ReadInt("Введите количество колонок: ");

int[,] matrix = FillMatrix(row, col, 0, 10);

PrintMatrix(matrix);
System.Console.WriteLine();

ChangeMatrix(matrix);
PrintMatrix(matrix);

