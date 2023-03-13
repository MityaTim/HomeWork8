void PrintArrays(int[][] ints)
{
    Console.WriteLine(
        string.Join("\n", ints.Select(
            x => string.Join(",", x)
        ))
    );
}
int FindMinStringIndex(int[][] arrays)
{
    int minStringIndex = int.MaxValue;
    int minStringSum = int.MaxValue;

    for (int i = 0; i < arrays.Length; i++)
    {
        int sum = arrays[i].Sum();
        if (sum < minStringSum)
        {
            minStringSum = sum;
            minStringIndex = i;
        }
    }
    return minStringIndex;
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

int[][] arrays = MakeArraysWithRandomInts(3, 4);

PrintArrays(arrays);

int minStringIndex = FindMinStringIndex(arrays);

Console.WriteLine(minStringIndex + 1 + " строка");
