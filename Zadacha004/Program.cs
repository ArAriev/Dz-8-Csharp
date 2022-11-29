// Показать треугольник Паскаля Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Введите размер треугольника паскаля");
int n = int.Parse(Console.ReadLine()??"0");

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (i == j || j == 0)
            {
                arr[i, j] = 1;
            }
            else if (j > i)
            {
                arr[i, j] = 0;
            }
            else if (i != j)
            {
                arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
            }
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {    
        int a = n*2;
        int N = n/2 +i;
        while( N < a){
        Console.Write(" ");
        a--;
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {  
            if (arr[i,j] == 0){
            Console.Write(" ");
            } else{
            Console.Write(" " + arr[i, j]);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] array = new int[n, n*2];

FillArray(array);
PrintArray(array);
