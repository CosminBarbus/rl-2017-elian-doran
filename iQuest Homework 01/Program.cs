using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElianDoran.iQuest.Homework01
{
    class Program
    {
        static void Pause()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            List<Animal> animals = Animal.GetAllAnimals();

            foreach (var animal in animals)
            {
                Console.WriteLine(String.Format("The {0} makes {1}", animal.Name, animal.Sound));
            }

            Pause();
        }
    }
}
