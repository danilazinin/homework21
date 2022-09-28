Console.Clear();
Console.WriteLine("");
int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);

Console.WriteLine($"строка {AnaliticArray(array)} имеет наименьшую сумму");

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

int AnaliticArray(int[,] array1)
{
    int  num = 0;
    int sum = 0;
    int sumMin = 1000;
    int kol = 1;
    int chil = 0;

    for (int index = 0; index < array1.GetLength(1); index++)
    {
        sum = 0;

        for (int i = 0; i < array1.GetLength(0); i++)
        {
            num = array1[index, i];
            sum = sum + num;
            num++;
            
        }
        
        Console.WriteLine($"сумма {kol} строки = {sum}");
        Console.WriteLine(" ");

        if (sum < sumMin)
        {
            sumMin = sum;
            sum = sumMin;
            chil = kol;  
        }
        kol++;

    } 
    return chil;

}
