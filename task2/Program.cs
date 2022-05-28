void FillArray(double[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)  // 0 = 3
{
    for(int j = 0; j < any.GetLength(1); j++) // 1 = 4 and etc
    {
        any[i, j] = new Random().Next(0, 10);
    }
}
}
void PrintArray(double[,] any)
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
void Change(double[,] any)
{
for(int i = 0; i < any.GetLength(0); i++)  // 0 = 3
{
    for(int j = 0; j < any.GetLength(1); j++) // 1 = 4 and etc
    {
        if(any[i, j] % 2 == 0 && any[i, j]!= 0)
        {
            any[i, j] = -any[i, j];
        }
    }
Console.WriteLine();
}
}
//В двумерном массиве n×k заменить четные элементы на противоположные
Console.WriteLine("How much rows in array?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in array?");
int columns = int.Parse(Console.ReadLine());
double[,] array = new double[rows, columns];
FillArray(array);
PrintArray(array);
Change(array);
Console.WriteLine();
Console.WriteLine();
PrintArray(array);

