// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] array = Random3DArray(2, 2, 2);
Print3DArray(array);
Console.WriteLine();

int[,,] Random3DArray(int x, int y, int z)
{
    int[,,] new3DArray = new int[x, y, z];
    Random randGenerator = new Random();
    for (int i = 0; i < x; i++) 
    {
        for (int j = 0; j < y; j++) 
        {
            for (int k = 0; k < z; k++)
            {
                new3DArray[i, j, k] = randGenerator.Next(10, 100);
            }
        }
    }
    return new3DArray;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine("");
        }
    }
}