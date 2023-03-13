using System.Text;

int[][][] Make3DArrayOfRandomInts()
{
    int[][][] array3D = 
    {
        new[] { new int[2], new int[2] },
        new[] { new int[2], new int[2] }
    };

    List<int> usedInts = new();
    foreach (int[][] array in array3D)
        foreach (int[] array1 in array)
            for (int i = 0; i < array1.Length; i++)
            {
                int next;
                do
                {
                    next = Random.Shared.Next(0, 100);
                } while (usedInts.Any(x => x == next));

                usedInts.Add(next);
                array1[i] = next;
            }
    return array3D;
}

string Array3DToString(int[][][] ints2D)
{
    StringBuilder result = new();
    for (int i = 0; i < ints2D.Length; i++)
        for (int j = 0; j < ints2D[i].Length; j++)
        {
            for (int k = 0; k < ints2D[i][j].Length; k++)
                result.Append($"{ints2D[i][j][k]}({i},{j},{k}) ");
            
            result.Append('\n');
        }
    return result.ToString();
}
int[][][] array3D = Make3DArrayOfRandomInts();
Console.WriteLine(Array3DToString(array3D));