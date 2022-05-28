//Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FillArray(int[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        any[i, j] = i + j;
}
}
}
void PrintArray(int[,] any)
{
for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        Console.Write($"{any[i, j]} ");
    }
Console.WriteLine();
}
}
Console.WriteLine("How much rows in array?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in array?");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);