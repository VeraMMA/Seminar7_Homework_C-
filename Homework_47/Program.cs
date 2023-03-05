
        static void Print(string word)
        {
            System.Console.WriteLine(word);
        }
            Print("Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");

        void FillMatrix(Double[,] matr)
        {   
            Random rand = new Random();

            for (int rows = 0; rows < matr.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matr.GetLength(1); columns++)
                {

                    matr[rows, columns] = Math.Round(rand.NextDouble() * 100, 2);

                }
            }
        }

            void PrintMatrix(Double[,] matr)
            {
                for (int rows = 0; rows < matr.GetLength(0); rows++)
                {
                    for (int columns = 0; columns < matr.GetLength(1); columns++)
                    {
                        Console.Write($"{matr[rows, columns]}\t");

                    }
                    System.Console.WriteLine();
                }
            }
             Double[,] matrix = new Double[3, 4];
             
              FillMatrix(matrix);
              PrintMatrix(matrix);

        

