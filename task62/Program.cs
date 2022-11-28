//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 


 Console.WriteLine("Введите размер массива");



 int[,] nums = new int[4,4];

 int num =1;
 int i =0;
 int j=0;

 while (num<=4*4)
 {
    nums[i,j]=num;
    if(i <= j+1 && i+j < 3)
    {
        ++j;
    }
    else if (i < j && i+j >= 3)
    {
        ++i;
    }
    else if (i >= j && i+j > 3)
    {
        --j;
    }
    else
    {
        --i;
    }
    ++num;
}

PrintArray(nums);

void PrintArray (int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+"\t");

        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}
