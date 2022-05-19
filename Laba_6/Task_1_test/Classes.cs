using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_test
{
    abstract class Alcohol
    {
        public int strenght { get; set; }
        public int volume { get; set; }

        public Alcohol(int strenght, int volume)
        {
            Console.WriteLine("Alcohol constructor");
            this.strenght = strenght;
            this.volume = volume;
        }
        public abstract void drink();
        public virtual void pour()
        {
            Console.WriteLine("*sounds of alcohol pour*");
        }


    }


    internal class AlcoholMix : Alcohol
    {
        public AlcoholMix(int strenght, int volume) : base(strenght, volume)
        {
            Console.WriteLine("AlcoholMix constructor");
        }

        public override void drink()
        {
            Console.WriteLine("drink something whith alcohol");
        }

        public new void pour()
        {
            Console.WriteLine("*sounds of something wihth aclohol pour*");
        }
    }


    internal class Beer : Alcohol
    {
        public int cost { get; set; }
        public string Name { get; set; }
        public Beer(string Name, int cost, int strenght, int volume) : base(strenght, volume)
        {
            Console.WriteLine("Beer constructor");
            this.Name = Name;
            this.cost = cost;
        }
        public override void drink()
        {
            Console.WriteLine($"drink {Name} beer");
        }

        public override void pour()
        {
            Console.WriteLine($"*sounds of {Name} pour*");
        }

        public void callFriends()
        {
            Console.WriteLine($"invite friends to drink beer");
        }
    }



    internal class Whisky : Alcohol
    {
        public int cost { get; set; }

        public string Name { get; set; }

        public bool whithice { get; set; }
        public Whisky(string Name, int cost, int strenght, int volume) : base(strenght, volume)
        {
            Console.WriteLine("Whisky constructor");
            this.Name = Name;
            this.cost = cost;
            whithice = false;
        }
        public override void drink()
        {
            if (whithice)
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
