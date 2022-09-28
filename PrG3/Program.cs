

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine() ?? string.Empty);


int[,] array1 = GetArray(row, columns, 1, 9);
PrintArray(array1);
Console.WriteLine();

int[,] array2 = GetArray(row, columns, 1, 9);
PrintArray(array2);

Console.WriteLine();

int[,] newArray = Composition(array1, array2);
PrintArray(newArray);

int[,] GetArray(int m, int n, int minVaiue, int maxVaiue)
{
    int[,] array = new int[m, n];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            array[i,j] = new Random().Next(minVaiue, maxVaiue +1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Composition(int[,] arr1, int[,] arr2)
{
    int r = array1.GetLength(0);
    int c = array2.GetLength(1);
    int[,] array3 = new int[r,c];
    for(int i = 0; i<arr1.GetLength(0); i++)
    {
        for(int j = 0; j<array2.GetLength(0); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                array3[i,j] += array1[i,k] * array2[k,j]; 
            }
        }
    }
    return array1;
}