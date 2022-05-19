using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
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
}
