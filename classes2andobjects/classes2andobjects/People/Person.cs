using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes2andobjects.People
{
    class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine($"My name is {Name} and I am {Age} years old!");
        }
    }

    class Clothing
    {
        public string Color;
        public string material;
        public int size;

        public void Tshirt()
        {
            Console.WriteLine($"The Tshirt is {Color} in color, made of {material} and {size} in size.");

        }

        public void Trousers()
        {
            Console.WriteLine($"The Tshirt is {Color} in color, made of {material} and {size} in size.");
        }
    }
}
