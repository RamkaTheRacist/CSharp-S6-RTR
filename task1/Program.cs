void FillArray(int[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)  // 0 = 3
{
    for(int j = 0; j < any.GetLength(1); j++) // 1 = 4 and etc
    {
        any[i, j] = new Random().Next();
    }
}
}
void PrintArray(int[,] any)
{
for(int i = 0; i < any.GetLength(0); i++)  // 0 = 3
{
    for(int j = 0; j < any.GetLength(1); j++) // 1 = 4 and etc
    {
        Console.Write($"{any[i, j]} ");
    }
Console.WriteLine();
}
}
//Показать двумерный массив размером m×n заполненный целыми числами
Console.WriteLine("How much rows in array?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much rows in columns?");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);