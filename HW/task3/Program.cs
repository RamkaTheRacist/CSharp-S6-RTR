//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillArray(int[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)  // 0 = 3
{
    for(int j = 0; j < any.GetLength(1); j++) // 1 = 4 and etc
    {
        any[i, j] = new Random().Next(1, 10);
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
void PowElements(int[,] any)
{
    for(int i = 0; i<any.GetLength(0); i++)
    {
        for(int j = 0; j<any.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                any[i, j] = (int)Math.Pow(any[i, j], 2);
            }
        }
    }
}
Console.WriteLine("How much rows in array?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in array?");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine("Was:");
PrintArray(array);
PowElements(array);
Console.WriteLine();
Console.WriteLine("Is:");
PrintArray(array);