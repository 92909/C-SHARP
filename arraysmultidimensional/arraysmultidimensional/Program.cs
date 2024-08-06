
using System;

namespace multidimensionalArrays
{
    class multidimansionArrays
    {
        static void Main(string[] args)
        {
            int[,] myNumbers = { { 1, 6, 3 }, { 4, 8, 13 } };
            Console.WriteLine(myNumbers[0, 1]);
            // you can loop in the multidimensiona arrays
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
            // you can also create a for loop 
            for (int i = 0; i < myNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < myNumbers.GetLength(1); j++)
                {
                    Console.WriteLine(myNumbers[i, j]);
                    Console.ReadKey();
                }
            }
        }
    }
}

