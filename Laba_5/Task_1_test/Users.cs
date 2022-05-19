using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Users
    {
        List<Tarify> tarifiesOfUsers = new List<Tarify>();
        public List<Tarify> TarifesOfUser
        {
            get
            {
                return tarifiesOfUsers;
            }
        }
        public string name;
        public Users(string n)
        {
            name = n;
        }
        public void useusl(Tarify gt)
        {
            TarifesOfUser.Add(gt);
        }
        public int getSumm()
        {
            int s = 0;
            foreach (Tarify item in tarifiesOfUsers)
            {
                s += item.cost;
            }
            return s;
        }
    }
}
