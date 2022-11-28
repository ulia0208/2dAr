// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



Console.WriteLine($"Введите первое число ");
int x=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите второе число ");
int y=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите третье число ");
int z=Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"");

int[,,] array3d = new int[x,y,z];



void WriteArray(int[,,] array3d)
{
    for (int i=0; i<array3d.GetLength(0); i++)
    {
        for (int j=0; j<array3d.GetLength(1); j++)
        {
            for (int k=0; k<array3d.GetLength(2); k++)
            {
                Console.Write($"  {array3d[i,j,k]}({i}, {j}, {k}); ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
       
    }
    Console.WriteLine();
    
}

void CreateArray(int[,,] arry3d)
{
    int[] Arr = new int[array3d.GetLength(0)*array3d.GetLength(1)*array3d.GetLength(2)];
    int num;
    for (int i=0; i<Arr.GetLength(0); i++)
    {
        Arr[i] = new Random().Next(0,100);
        num=Arr[i];
        if (i>=1)
        {
            for (int j=0; j<i; j++)
            {
                while (Arr[i] == Arr[j])
                {
                    Arr[i]=new Random().Next(0,100);
                    j=0;
                    num=Arr[i];
                }
                num=Arr[i];
            }
        }
    }
    int count=0;
    for (int x=0; x<array3d.GetLength(0); x++)
    {
        for (int y=0; y<array3d.GetLength(1); y++)       
        {
            for (int z=0; z<array3d.GetLength(2); z++)
            {
                array3d[x,y,z] = Arr[count];
                count++;
            }
        }
    }
}
CreateArray(array3d);
WriteArray(array3d);
