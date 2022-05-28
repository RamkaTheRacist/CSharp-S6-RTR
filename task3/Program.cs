//В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
void FillArray(int[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        any[i, j] = new Random().Next(0, 10);
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
void Find(int[,] any, int number)
{
int tmp = 0;
int tmpi = 0;
int tmpj = 0;
for(int i = 0; i < any.GetLength(0); i++)
{
    if(tmp == 0)
    {
    for(int j = 0; j < any.GetLength(1); j++)
    {
        if(any[i, j] == number) 
        {
            tmp++;
            tmpi = i;
            tmpj = j;
            break;
        }
    }
    }
    else break;
}
if(tmp > 0) Console.WriteLine($"Position of {number} is [{tmpi}, {tmpj}]");
else Console.WriteLine($"{number} isnt in array");
}
Console.WriteLine("How much rows in array?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in array?");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
Console.WriteLine("Which number?");
int number = int.Parse(Console.ReadLine());
FillArray(array);
PrintArray(array);
Find(array, number);


