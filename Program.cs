Console.Clear();
restart:
Console.WriteLine("1-3 Практические задачи");
Console.Write("Что бы запустить какую то конкретную задачу введите номер этой задачи то 1 до 3: ");
int Task = int.Parse(Console.ReadLine());
switch (Task)
{
    case 1: /*Задание 47: сделать двумерный массив заполненный вещественными числами*/
        void InputMatrixDouble(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round(new Random().NextDouble() * 10, 1); // [-10, 10]
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        Console.Write("Введите размер матрицы: ");
        int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
        double[,] matrix = new double[coord[0], coord[1]];
        InputMatrixDouble(matrix);
        break;
    case 2: /*Задание 50: написать позицию элемента в дувумерном массиве и получить значение элемента или что такого элемента нет*/
        int[,] InputMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(1, 11); // [1, 10]
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            return matrix;
        }
        void SearchElementMatrix(int[,] matrix, int[] positions)
        {
            if (positions[0] < matrix.GetLength(0) && positions[1] < matrix.GetLength(1))
                Console.WriteLine(matrix[positions[0], positions[1]]);
            else Console.WriteLine("Нет такого элемента");
        }
        Console.Write("Введите размер матрицы: ");
        coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
        int[,] matrix1 = new int[coord[0], coord[1]];
        InputMatrix(matrix1);
        System.Console.WriteLine();
        Console.Write("Введите позицию элемента матрицы: ");
        int[] elem = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
        SearchElementMatrix(matrix1, elem);
        break;
    case 3:/*Задание 52: задать массив целых чисел и в каждом столбце вычислить среднее арифметическое*/
        double[] ArithmeticMeanMatrix(int[,] matrix)
        {
            double[] arithmetic = new double[matrix.GetLength(0)];
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                    sum = matrix[i, j] + sum;
                arithmetic[i] = Math.Round(sum / matrix.GetLength(0), 1);
            }
            return arithmetic;

        }
        int[,] matrix2 = new int[4, 3];
        InputMatrix(matrix2);
        Console.WriteLine();
        Console.WriteLine($"[{string.Join("; ", (ArithmeticMeanMatrix(matrix2)))}]");
        break;
    default:
        goto restart;
}

