namespace lab1
{
    public class PropertiesMatrix
    {
        public static int[,] CreateMatrix()
        {
            bool flag = true;
            int number = 0;
            while (flag)
            {
                Console.Write("Enter the matrix size (n): ");
                string? n = Console.ReadLine();

                if (int.TryParse(n, out number))
                    if (number <= 0)
                        Console.WriteLine("Size < 1");
                    else flag = false;
                else
                    Console.WriteLine("Error value");

            }

            int[,] relationMatrix = new int[number, number];
            for (int i = 0; i < number; i++)
                for (int j = 0; j < number; j++)
                    relationMatrix[i, j] = new Random().Next(0, 2);

            return relationMatrix;
        }
        public static void ShowMatrix(int[,] relationMatrix)
        {
            Console.WriteLine("Matrix");
            for (int i = 0; i < relationMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < relationMatrix.GetLength(1); j++)
                    Console.Write(relationMatrix[i, j].ToString());
                Console.WriteLine();
            }
        }
        public static bool IsAntiReflexive(int[,] relationMatrix)
        {
            int size = relationMatrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                if (relationMatrix[i, i] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSymmetric(int[,] relationMatrix)
        {
            int size = relationMatrix.GetLength(0);
            for (int i = 0; i < size-1; i++)
            {
                for (int j = i+1; j < size; j++)
                {
                    if (relationMatrix[i, j] != relationMatrix[j, i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsAsymmetric(int[,] relationMatrix)
        {
            int size = relationMatrix.GetLength(0);
            for (int i = 0; i < size-1; i++)
            {
                if (relationMatrix[i, i] == 1)
                    return false;
                for (int j = i+1; j < size; j++)
                {
                    if (relationMatrix[i, j] == 1 && relationMatrix[j, i] == 1)
                    {
                        return false;
                    }
                }
            }
            return (relationMatrix[size - 1, size - 1] == 0) ;
                
            
        }
    }
}
