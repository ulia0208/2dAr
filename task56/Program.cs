// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void InputMatrix (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0);i++)
    {
        for (int j=0;j<matrix.GetLength(1);j++)
        {
            matrix[i,j]=new Random().Next(0,10);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

 void ReleaseMatrix(int[,] matrix)
 {
    int index=0;
    int min=0;
    for (int i=0; i<matrix.GetLength(0);i++)
    {
        int sum=0;
        for (int j=0;j<matrix.GetLength(1);j++)
        {
            sum+=matrix[i,j];
        }
        Console.WriteLine($"Сумма {i+1}строки={sum}");
        if (i==0)
        {
            min=sum;

        }
        else if (sum<min)
        {
            min=sum;
            index=i;
        }
    }
    string line=string.Empty;

    for (int j=0;j<matrix.GetLength(1);j++)
    {
        line+=matrix[index,j] + " ";
    }

    Console.WriteLine($"Строка с минимальной суммой={line}");

 }


Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine()!.Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Начальный массив: \n");
InputMatrix(matrix);
ReleaseMatrix(matrix); 

