//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int Numbers(string input)
{
  Console.Write(input);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

// int [, ,] GetRandom (int rows, int columns, int whatisit)
// {
//     int [, ,] matrix = new int [rows, columns, whatisit];
//     for (int i = 0; i < matrix.GetLength (0); i++) 
//     {
//        for (int j = 0; j < matrix.GetLength (1); j++)
//        {
//         for (int x = 0; x < matrix.GetLength (2); x++)
//        {
//         matrix[i, j, x] = Random.Shared.Next(10, 100);
//        }
//     }   
// }
// return matrix;
// }

void print (int [, , ] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
       {
        for (int x = 0; x < matrix.GetLength (2); x++)
        {
         Console.Write($"({i}, {j}, {x}) {matrix[i, j, x]}  ");
        }
    Console.WriteLine();
    
    }
    }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}


Console.WriteLine($"Введите размер массива1 m x n x l:");
int m1 = Numbers ("Введите m: ");
int n1 = Numbers ("Введите n: ");
int l1 = Numbers ("Введите l: ");
int [, ,] myMatrix1 = new int[m1, n1, l1];
CreateArray(myMatrix1);
print (myMatrix1);