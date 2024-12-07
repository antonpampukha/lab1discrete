using static lab1.PropertiesMatrix;

namespace lab1
{
    static class Menu
    {
        public static void ShowMenu(int[,] relationMatrix)
        {

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nSelect the property to check:");
                Console.WriteLine("1. Anti-reflectivity");
                Console.WriteLine("2. Symmetry");
                Console.WriteLine("3. Asymmetry");
                Console.WriteLine("0. Exit");

                Console.Write("Your select: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Anti-reflectivity: " + IsAntiReflexive(relationMatrix));
                        break;
                    case "2":
                        Console.WriteLine("Symmetry: " + IsSymmetric(relationMatrix));
                        break;
                    case "3":
                        Console.WriteLine("Asymmetry: " + IsAsymmetric(relationMatrix));
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Wrong choice. Try again");
                        break;
                }
            }
        }
    }
}

