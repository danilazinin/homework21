Console.Clear();

int[,,] array = GetArray(2, 2, 2);
PrintArray(array);

int[,,] GetArray(int m, int n, int l)
{

    int[,,] result = new int[m, n, l];
    result[0, 0, 0] = new Random().Next(10, 21);
    int r = result[0, 0, 0];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int e = 0; e < l; e++)
            {

                result[i, j, e] = new Random().Next(1, 10) + r;
                r = result[i, j, e];
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int e = 0; e < inArray.GetLength(2); e++)
            {
                Console.Write($"{inArray[i, j, e]} ({i},{j},{e}) ");
            }
            Console.WriteLine();
        }

    }

}
