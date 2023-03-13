void PrintArrays(int[][] ints)
{
    Console.WriteLine(
        string.Join("\n", ints.Select(
            x => string.Join(",", x)
        ))
    );
}

int[][] MakeArraysWithRandomInts(int height, int width)
{
    int[][] ints = new int[height][];
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = new int[width];
        for (int j = 0; j < width; j++) ints[i][j] = Random.Shared.Next(0, 10);
    }
    return ints;
}

int [][] MultiplyMatrix2X2(int[][] a, int[][] b)
{
    int[][] r = new int[2][];
    for (int i = 0; i < r.Length; i++) r[i] = new int[2];

    for (int i = 0; i <2; i++)
        for (int j = 0; j < 2; j++)
            for (int k = 0; k < 2; k++)
                r[i][j] += a[i][k] * b[k][j];

    return r;
}
int[][] matrix1 = MakeArraysWithRandomInts(2, 2);
int[][] matrix2 = MakeArraysWithRandomInts(2, 2);

PrintArrays(matrix1);
Console.WriteLine("-------------");
PrintArrays(matrix2);

int[][] result = MultiplyMatrix2X2(matrix1, matrix2);

Console.WriteLine("-------------");
PrintArrays(result);