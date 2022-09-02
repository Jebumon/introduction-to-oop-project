using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionTo_OOPs_Project.Models
{
    public class Pigeon : Bird
    {
        //The Pigeon constructor calls the base class Bird constructor
        //The name and color parameters are passed to the Bird constructor
        public Pigeon(string name, string color) : base(name, color)
        {
        }

        public void EatPizza()
        {
            Console.WriteLine("Delicious pizza!");
        }

        public void Sleep()
        {
            Console.WriteLine("I'm, a sleeping pigeon");
        }
    }
}
