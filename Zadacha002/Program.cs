// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Console.Clear();
void PrintArray(int[,] array)
{
    for (int i = 0; i < 6; i++) 
    {
        for (int j = 0; j < 6; j++) 
        {
        Console.Write($"{array[i, j]} "); 
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            matr[i, j] = new Random().Next(1,10); 
        }
        
    }
}
int k = 6;
int n = 6;
int[,] array = new int[k, n];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine(); 
int x = 0; 
int y = 0; 
int min = array[0, 0]; 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++) 
    {
        if (array[i, j] < min) 
        {
            min = array[i, j]; 
            x = i;
            y = j;
        }
    }
}
Console.WriteLine("Наименьший элемент двумерного массива: " + min);
Console.WriteLine("Измененный массив после удаления: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        {
            if ((i == x) || (j == y)) 
            continue;
            else Console.Write(array[i, j] + " "); 
        }
    }
    Console.WriteLine();
}

