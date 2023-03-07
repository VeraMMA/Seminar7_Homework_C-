static void Print(string word)
{
    System.Console.WriteLine(word);
}
           
        void FillMatrix(int [,] matr)
        { Print("Заполните массив целыми числами");
            Random rand = new Random();
            for (int rows = 0; rows < matr.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matr.GetLength(1); columns++)
                {

                    matr[rows, columns] = rand.Next(1, 10);

                }
            }
        }

            void PrintMatrix(int [,] matr)
            { Print("Вывод массива");
                for (int rows = 0; rows < matr.GetLength(0); rows++)
                {
                    for (int columns = 0; columns < matr.GetLength(1); columns++)
                    {
                        Console.Write($"{matr[rows, columns]}\t");

                    }
                    System.Console.WriteLine();
                }   
            }


            void FindElement(int [,] matr, int element)
            { 
                bool find = false;
                for (int rows = 0; rows < matr.GetLength(0); rows++)
                {
                    for (int columns = 0; columns < matr.GetLength(1); columns++)
                    {
                       if (matr[rows, columns] == element)
                       {
                        Console.Write($"Ваше число находится в координате: {rows} + {columns}\t");
                        find = true;
                       }  
                    }
                    if (!find)
                       {
                       Console.Write("такого числа в массиве нет");
                       }break;
                }   
            }

int [,] matrix = new int [3, 4];
      Print("Введите число");
      int element = Convert.ToInt32(Console.ReadLine());       
              FillMatrix(matrix);
              PrintMatrix(matrix);
              FindElement(matrix, element);