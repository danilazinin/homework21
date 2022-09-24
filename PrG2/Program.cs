Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количествa столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

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

void AnaliticPrintArray(int[,] array1, int a, int b)
{
    double num = 0;
    double sum = 0;
    int n = 1;
    int sumMin = 1000;
    for (int index = 0; index < array1.GetLength(1); index++)
    {
        sum = 0;

        for (int i = 0; i < array1.GetLength(0); i++)
        {
            num = array1[i, index];
            sum = sum + num;
            num++;
            // Console.WriteLine($"сумма - {sum}");
        }

        if (sum < sumMin )
        {
            sum = sumMin;
            Console.WriteLine(sumMin);
        }
    }   
}
