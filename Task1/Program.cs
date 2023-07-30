// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void PrintCheckElement(int [,] massive, int index)
// {
//     for(int i = 0; i < massive.GetLength(0); i++)
//     {
//         for(int j = 0; j < massive.GetLength(1); j++)
//         {
//             if(massive[i] = index) Console.Write($"{index} -> {massive[i]}");
//             if( massive[j] = index ) Console.Write($"{index} -> {massive[j]}");
//             else Console.Write($"{index} -> not exist");
//         }
//     }
// }

//I DONT UNDERSTAND HOW TO CHECK INDEX IN THIS KIND OF MASSIVE[,] CAN YOU EXPLAIN
void PrintCheckElement(int [,] massive, int index)
{
    if(index > massive.GetLength(0)) Console.Write($"{index} -> not exist");
    for( int i = 0; i < massive.GetLength(0); i++)
    {
        if (index == massive[i]) Console.Write($"{index} -> {massive[i]}"); //I DONT UNDERSTAND HOW TO CHECK INDEX IN THIS KIND OF MASSIVE[,] CAN YOU EXPLAIN
    }
}
    
    
   
void PrintDoDoubleMassive(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int GetPos(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Enter numbers of rows: ");
int columns = GetInfo ("Enter numbers of columns: ");
int index = GetPos(" Enter index of element: ");
int element = CheckElement(index);
int[,] massive = DoDoubleMassive(rows, columns, 0, 9);
PrintDoDoubleMassive(massive);
PrintCheckElement(index);