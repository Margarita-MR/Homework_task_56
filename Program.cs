// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random random = new Random();

int [,] array = new int[7, 5];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
Console.WriteLine();
}
int minStrSum = int.MaxValue, indexMinStr = 0;
 
             for (int i = 0; i < array.GetLength(0); i++)
             {
                int StrSum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                    StrSum += array[i, j];
                
                if (StrSum < minStrSum)
                {
                    minStrSum = StrSum;
                    indexMinStr = i;
                }
                for(int j = 0; j < array.GetLength(1); j++) break;
             }
             Console.WriteLine("Минимальная сумма элементов в " + $"{indexMinStr+1} строке");
                 
                      Console.Write(indexMinStr+1); 
                    