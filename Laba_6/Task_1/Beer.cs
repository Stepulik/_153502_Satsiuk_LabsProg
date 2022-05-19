using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;

namespace Task_1
{
    internal class Beer: Alcohol
    {
        public int cost { get; set; }
        public string Name { get; set; }
        public Beer(string Name, int cost, int strenght, int volume) : base (strenght, volume)
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

        public void callFriends(bool isTrue)
        {
            Console.WriteLine($"invite friends to drink beer");
            if (!isTrue)
            {
                Console.WriteLine("*Your friends dont come*");
            }
        }
    }
}
