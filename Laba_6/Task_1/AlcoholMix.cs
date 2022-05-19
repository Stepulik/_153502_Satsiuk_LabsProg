using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    sealed internal class AlcoholMix : Alcohol
    {
        public bool isNormal { get; set; }
        public AlcoholMix (int strenght, int volume) : base(strenght, volume)
        {
            Console.WriteLine("AlcoholMix constructor");
            isNormal = true;
        }
        
        public override void drink()
        {
            Console.WriteLine("drink something whith alcohol");
            if (!isNormal)
            {
                Console.WriteLine("*You were poisoned by Alcohol Mix*");
            }
        }

        public new void pour()
        {
            Console.WriteLine("*sounds of something wihth aclohol pour*");
        }
    }
}
