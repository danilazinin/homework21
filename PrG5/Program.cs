// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = SpiralArray();
PrintArray(array);

int[,] SpiralArray()
{
    int[,] inArray = new int[4,4];
    int num = 1;
    for(int j = 0; j < inArray.GetLength(1); j++)
    {
       inArray[0,j] = num;
       num++;
    }
    for(int i = 1; i < inArray.GetLength(0); i++)
    {
        inArray[i, inArray.GetLength(0) -1] = num;
        num++;
    }
    for(int j = inArray.GetLength(1) -2; j >=0; j--)
    {
        inArray[inArray.GetLength(1) -1, j] = num;
        num++;
    }
    for(int i = inArray.GetLength(0)-2; i >0; i--)
    {
        inArray[i,0] = num;
        num++;
    }
    int c = 1;
    int d = 1;
    while (inArray[c, d + 1] == 0) 
    {
        inArray[c, d] = num;
        num++;
        d++;
    }
    while(inArray[c + 1,d] == 0)
    {
        inArray[c,d] = num;
        num++;
        c++;
    }
     while(inArray[c,d-1] == 0)
    {
        inArray[c,d] = num;
        num++;
        d--;
    }
     while(inArray[c-1,d] == 0)
    {
        inArray[c,d] = num;
        num++;
        c--;
    }
    for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            if (inArray[i,j] == 0) 
            {
                inArray[i,j] = num;
            }
        }
    }
    return inArray;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i<inArray.GetLength(0); i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
