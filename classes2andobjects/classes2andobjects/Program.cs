
using System;
using classes2andobjects.People;

namespace classesandobjects2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Jackson";
            person1.Age = 21;
            person1.HasPet = true;

            person1.Greeting();
            Console.ReadKey();

            Clothing clothing = new Clothing();
            clothing.Color = "Red";
            clothing.material = "Cotton";
            clothing.size = 42;

            clothing.Trousers();
            clothing.Tshirt();
            Console.ReadKey();
        }
    }
}