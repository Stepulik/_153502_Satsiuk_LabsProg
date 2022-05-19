using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Whisky : Alcohol
    {
        public int cost { get; set; }

        public string Name { get; set; }

        public bool whithice { get ; set ;}
        public Whisky(string Name, int cost, int strenght, int volume) : base(strenght, volume)
        {
            Console.WriteLine("Whisky constructor");
            this.Name = Name;
            this.cost = cost;
            whithice = false;
        }
        public override void drink()
        {
            if(whithice)
                Console.WriteLine($"drink {Name} whisky whith ice");
            else
                Console.WriteLine($"drink {Name} whisky");

        }

        public override void pour()
        {
            Console.WriteLine($"*sounds of {Name} pour*");
        }

        public void addice()
        {
            volume = (int)(volume * 1.1);
            strenght = (int)(strenght * 0.9);
            whithice = true;
        }

        public void depression()
        {
            Console.WriteLine("fall into depression");
        }
    }
}
