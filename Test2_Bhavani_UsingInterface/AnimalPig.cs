using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Bhavani_UsingInterface
{
    public class AnimalPig : Interface1
    {
        public string Weight { get ; set; }
        public string Colour { get ; set ; }

        public void GetAnimalWeightAndColour()
        {
            Console.WriteLine("Enter weight of the Pig:");
            Weight = Console.ReadLine();
            Console.WriteLine("Enter colour of the Pig:");
            Colour = Console.ReadLine();
            Console.WriteLine("The Pig weight is " + Weight);
            Console.WriteLine("The Pig colour is" + Colour);

        }
    }
}
