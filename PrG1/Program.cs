

Console.Clear();



int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);

Console.WriteLine(" ");

int[,] array1 = AnaliticArray(array);
PrintArray(array1);






int[,] GetArray(int a, int b, int minValue, int maxValue)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] AnaliticArray(int[,] array1)
{
    int result = 0;
    int result1 = 0;
    int kol = 0;
    while (kol <= array1.GetLength(1))
    {
        for (int index = 0; index < array1.GetLength(1); index++)
        {


            for (int i = 0; i < array1.GetLength(0) - 1; i++)
            {

                if (array1[index, i + 1] > array1[index, i])
                {

                    result = array1[index, i + 1];
                    result1 = array[index, i];
                    array1[index, i] = result;
                    array1[index, i + 1] = result1;

                }

            }


        }
        kol++;
  }
    return array1;
}


