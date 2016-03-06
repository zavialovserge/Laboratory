using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) Create an arary of Animal objects and object of Animals    
            // print animals with foreach operator for object of Animals               
            Animal[] animal = new Animal[4];
            animal[0] = new Animal("Pig", 50);
            animal[1] = new Animal("Goat", 40);
            animal[2] = new Animal("Chicken", 25);
            animal[3] = new Animal("Elephant", 2000);
            Animals animals = new Animals(animal);
            Console.WriteLine("Animals:");
            foreach (Animal an in animal)
            {
                Console.WriteLine("{0},{1}",an.name,an.weight);
            }
            // 11) Invoke 3 types of sorting 
            // and print results with foreach operator for array of Animal objects         
            Console.WriteLine("Sorted by genus Ascending:");
            Array.Sort(animal);
            foreach (Animal an in animal)
            {
                Console.WriteLine("{0},{1}",an.name, an.weight);
            }
            Array.Sort(animal, Animal.SortGenusDescending);
            Console.WriteLine("Sorted by genus Descending:");
            foreach (Animal an in animal)
            {
                Console.WriteLine("{0},{1}", an.name, an.weight);
            }
            Array.Sort(animal, Animal.SortWeightAscending);
            Console.WriteLine("Sorted by weight:");
            foreach (Animal an in animal)
            {
                Console.WriteLine("{0},{1}", an.name, an.weight);
            }
            Console.ReadKey();
        }
    }
}
