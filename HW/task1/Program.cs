//Показать двумерный массив размером m×n заполненный вещественными числами
void FillArray(double[,] any, int minValue, int maxValue)
{
    for(int i = 0; i < any.GetLength(0); i++)  // 0 = 3
{
    for(int j = 0; j < any.GetLength(1); j++) // 1 = 4 and etc
    {
        any[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
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
Console.WriteLine("How much rows in array?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in array?");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Random number from?");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Random number to?");
int max = int.Parse(Console.ReadLine());
double[,] array = new double[rows, columns];
FillArray(array, min, max);
PrintArray(array);