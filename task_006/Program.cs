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
int m = 7, n = 8, item = 1;
int numItem = m * n;
int[,] array = new int[m, n];
int InRighti = 0;
int InRightRow = 0;
while (item <= numItem)
{
    for (int i = InRighti; i < n && item <= numItem; i++)
    {
        array[InRightRow, i] = item;
        item++;
    }
    for (int j = InRightRow + 1; j < m && item <= numItem; j++)
    {
        array[j, n - 1] = item;
        item++;
    }
    for (int k = n - 2; k > InRighti && item <= numItem; k--)
    {
        array[m - 1, k] = item;
        item++;
    }
    for (int t = m - 1; t > InRightRow && item <= numItem; t--)
    {
        array[t, InRightRow] = item;
        item++;
    }
    InRighti++;
    InRightRow++;
    m--;
    n--;
}

// int row = ReadInt("Введите кол-во колонок: ");
// int col = ReadInt("Введите кол-во столбцов: ");
// int[,] matrix = FillMatrix(row, col, 0, 1000);
// PrintMatrix(matrix);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
}