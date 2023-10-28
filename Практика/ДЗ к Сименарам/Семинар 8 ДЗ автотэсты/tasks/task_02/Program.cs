// Создание двумерного массива

double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) 
{
    
      // Введите свое решение ниже
   
      var rand = new Random();
      
      var randArr  = new double[m , n];

      for(int i = 0; i < randArr.GetLength(0);i++) 
      { 
        for (int j = 0; j < randArr.GetLength(1); j++)
        {
      
             randArr[i,j] = Math.Round(rand.NextDouble() + rand.Next(minLimitRandom,maxLimitRandom),3);
        }
     
      }
            return randArr;

}



void PrintArray(double[, ] matrix) 
{
      // Введите свое решение ниже

   for( int i = 0; i < matrix.GetLength(0); i++)
   {
     for ( int j = 0; j < matrix.GetLength(1); j++)
   
   
   Console.Write(matrix[i,j] + "\t");
  System.Console.WriteLine();
   }

}

double[,] arr = CreateRandomMatrix(3,5,-66,100);
PrintArray(arr);