using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionTo_OOPs_Project.Models
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color) 
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Hi I'm {Name} and I'm a {Color} parrot, I can sing.");
        }
    }

}
