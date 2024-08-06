
using System;

namespace arrays
{
    class arrays
    {
        static void Main(string[] args)
        {
            // lets go offtopic a bit
            int[] myNumbers = [21, 34, 54, 0, 2, 900, 1, 24, 12];
            string[] cars = { "Mazda", "Subaru", "Mercedez", "Toyota" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            // in arrays, instead of declaring many variable in several lines, you create one array
            // you use the square brackets => mynames[] = ["kim", "Kimani", "KAranja"]
            string[] cars1 = { "Mazda", "Subaru", "Mercedez", "Toyota" };// this is an array or
            int[] myNum = [21, 34, 65, 78, 12];
            // accessing them 
            Console.WriteLine(myNum[0]);
            // changing their value
            cars1[0] = "Bughati";
            foreach (string car4 in cars1)
            {
                Console.WriteLine(car4);
                Console.WriteLine(cars1.Length); // this outputs the number of elements in the array

            }
            for (int i = 0; i < cars1.Length; i++)
            {
                Console.WriteLine(cars1[i]);
            } 
            // you use this procedure for  forloop
            /* foreach (type variableName in arrayName) 
            {
             // code block to be executed
               }

            */
            // sorting an array => ypou can use the array.sort() which sorts it in an alphabetical order
            Console.WriteLine(" 4");
            Array.Sort(cars);
            foreach (string crs in cars)
            {
                Console.WriteLine(crs);
                Console.WriteLine(myNum.Length);// this counts the number of elements in an array
                Console.WriteLine(myNum.Min()); // outputs the smallest number
                Console.WriteLine(myNum.Max());//outputs the largest number
                Console.WriteLine(myNum.Sum()); //outputs the sum of numbers
            }

        }
    }
}