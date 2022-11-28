//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Random rnd=new Random();
int[,] CreateMatrix (int row, int col, int min, int max)
{
    int[,] matrix = new int [row,col];
    for (int i=0;i<matrix.GetLength(0);i++)
    {
        
        for (int j=0;j<matrix.GetLength(1);j++)
        {
            matrix[i,j]=rnd.Next(min,max+1);

        }
    }
    return matrix;
 
 }

void PrintMatrix(int[,] matrix)
{
    for (int i=0;i<matrix.GetLength(0);i++)
    {
        Console.Write("|");
        for (int j=0;j<matrix.GetLength(1);j++)
        {
            if (j<matrix.GetLength(1)-1)
            {
                Console.Write($" { matrix[i,j],1} ");
            }
            else 
            {
                Console.Write($" { matrix[i,j],1} ");
            }            
        }
        Console.WriteLine("|");
    }
 }

 int[,] DivMatrix (int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    { 
        for (int i=0;i<matrix3.GetLength(0);i++)
        {
            for (int j=0;j<matrix3.GetLength(1);j++)
            {
                matrix3[i,j]=0;
                for (int n=0;n<matrix1.GetLength(1);n++)
                {
                     matrix3[i,j]+=matrix1[i,n]*matrix2[n,j];
                     
                }

               
            }
            

        }
    }
    return matrix3;
 
 }


int[,] array2d=CreateMatrix(rnd.Next(2,5), rnd.Next(2,5),0,9);
int[,] matrix=CreateMatrix(rnd.Next(2,5), rnd.Next(2,5),0,9);
    PrintMatrix(array2d);
    Console.WriteLine();
    PrintMatrix(matrix);
    Console.WriteLine();
    PrintMatrix(DivMatrix(array2d, matrix));
    Console.ReadLine();
