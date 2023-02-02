System.Console.WriteLine("Введите количество строк матрицы");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов матрицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)  matrix[i,j] = new Random().Next(1,10);
}

void print (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
}
}

print(matrix);
System.Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if ((i + j) % 2 == 0 && i + j != 0)
        {
            matrix[i,j] *= matrix[i,j];
        }
    }
    
}

print(matrix);