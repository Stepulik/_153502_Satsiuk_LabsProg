using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1_;

namespace Task_1
{
    public sealed class jesrate : Rate
    {
        private jesrate()
        {

        }

        private static jesrate _instance;

        public static jesrate GetInstance()
        {
            if (_instance == null)
            {
                _instance = new jesrate();
            }
            return _instance;
        }



        private static int jesnum;

        public static int Jesnum
        {
            get { return jesnum; }
            set { jesnum = value; }
        }

        private static string area;

        public static string Area
        {
            get { return area; }
            set { area = value; }
        }


    }
}