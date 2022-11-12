using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Bhavani_UsingInterface
{
    public class AnimalDog : Interface1
    {
        public string Weight { get ; set ; }
        public string Colour { get ; set ; }

        public void GetAnimalWeightAndColour()
        {
            Console.WriteLine("Enter weight of the Dog:");
            Weight = Console.ReadLine();
            Console.WriteLine("Enter colour of the Dog:");
            Colour = Console.ReadLine();
            Console.WriteLine("The dog weight is "+Weight);
            Console.WriteLine("The dog colour is" +Colour);




        }
    }
}
