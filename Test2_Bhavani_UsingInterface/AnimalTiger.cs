using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Bhavani_UsingInterface
{
    public class AnimalTiger : Interface1

    {
        public string  Weight { get; set ; }
        public string Colour { get ; set; }

        public void GetAnimalWeightAndColour()
        {
            Console.WriteLine("Enter weight of the Tiger:");
            Weight = Console.ReadLine();
            Console.WriteLine("Enter colour of the Tiger:");
            Colour = Console.ReadLine();
            Console.WriteLine("The Tiger weight is " + Weight);
            Console.WriteLine("The Tiger  colour is" + Colour);

        }
    }
}
