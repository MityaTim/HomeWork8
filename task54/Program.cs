int[][] MakeArraysWithRandomInts(int height, int width)
{
    int[][] ints = new int[height][];
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = new int[width];
        for(int j = 0; j < width; j++) ints[i][j] = Random.Shared.Next(0, 10);
    }

    return ints;
}

int[][] arrays = MakeArraysWithRandomInts(height: 3, width: 4);

foreach (int[] array in arrays)
    Array.Sort(array, comparison: (x, y) => x < y ? 1 : -1);

Console.WriteLine(string.Join("\n", arrays.Select(x => string.Join(",", x))));
