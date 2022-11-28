// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{   

    
    int MinNumbers=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k< matrix.GetLength(1)-1; k++)
            {
                if (matrix[i, k] < matrix[i, k+1])
                {
  
                    MinNumbers=matrix[i, k];
                    matrix[i, k]=matrix[i, k+1];
                    matrix[i, k+1]=MinNumbers;
          
                }
           }
            
        }

    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}




Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine()!.Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Начальный массив: \n");
InputMatrix(matrix);
Console.WriteLine("Конечный массив: \n");
ReleaseMatrix(matrix); 
