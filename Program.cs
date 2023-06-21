/*
void ChangeRows(int[,] matr)
{
    int lastRowIndex = matr.GetLength(0) - 1;

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int temp = matr[0, i];
        matr[0, i] = matr[lastRowIndex, i];   
        matr[lastRowIndex, i] = temp; 
    }
}
*/
/*
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива. 
int row = 3;
int column = 4;

int[,] Array = GetMatrix(row, column); 
PrintMatrix(Array);
descending(Array);
Console.WriteLine();
PrintMatrix(Array);

int[,] GetMatrix(int m, int n)
{
int[,] matrix = new int[row, column];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j <matrix.GetLength(1); j++)
   {
        matrix[i,j] = matrix[i,j] = new Random().Next(0, 10 + 1);
    }
}
        return matrix;

}

void PrintMatrix(int[,] array)
{
 for(int i = 0; i < array.GetLength(0); i++)
  
   {
      for(int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write(array[i, j] + " ");
       }
       Console.WriteLine();
   }
}

void descending(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
    
      for(int j = 0; j < array.GetLength(1); j++)
      {
          for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
           
                 }
            }
        } 
   }          
}  
 */   



/*
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов
int sumColumn = 0; 
int row = 3;
int column = 4;
int StringSmallestSum = 0;
int StringMinSunElements = 0;
int NumberString = 0;

int[,] Array = GetMatrix(row, column); 
PrintMatrix(Array);
FinSallestSum(Array);


int[,] GetMatrix(int m, int n)
{
int[,] matrix = new int[row, column];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j <matrix.GetLength(1); j++)
   {
        matrix[i,j] = matrix[i,j] = new Random().Next(0, 100 + 1);
    }
}
        return matrix;

}
void PrintMatrix(int[,] array)
{
 for(int i = 0; i < array.GetLength(0); i++)
  
   {
      for(int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write(array[i, j] + "\t");
       }
       Console.WriteLine();
   }
}

void FinSallestSum(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
    sumColumn = 0;
      for(int j = 0; j < array.GetLength(1); j++)
      {
       sumColumn = (sumColumn + array[i,j]);
      }   
   StringSmallestSum = sumColumn;
        if(i>0)
        {
          if(StringMinSunElements > StringSmallestSum)
           {
            StringMinSunElements = StringSmallestSum;
            NumberString = i;
           }
        }  
       else
        {
            StringMinSunElements = StringSmallestSum;
        }
    }
}  
    Console.Write("Cтрока с наименьшей суммой элементов =" +  (NumberString + 1));
*/