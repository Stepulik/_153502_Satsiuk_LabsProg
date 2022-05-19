using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Potreblenye
    {
        List<Tarify> tarifies = new List<Tarify>();
        List<Users> lstUsers = new List<Users>();
        Users users;
        enum Tar
        {
            voda,
            electr,
            otoplenye,
            gas,
            arenda
        }

        public void addTar(string namet, int cost) //add tarif
        {
            tarifies.Add(new Tarify(namet, cost));
        }
        public void AddUser(string name) //adduser  
        {
            lstUsers.Add(new Users(name));
        }

        public Users GetByName(string n) //getname in list
        {
            foreach (Users item in lstUsers)
            {
                if (item.name == n)
                {
                    return item;
                }

            }
            return null;
        }
        public void login(string n)
        {
            if (users == null)
            {
                users = GetByName(n);
            }
        }
        public void logout()
        {
            users = null;
        }
        Tarify GetTarByTitle(string t)
        {
            foreach (Tarify item in tarifies)
            {
                if (item.namet == t) return item;
            }
            return null;
        }
        public void BuyTarifes(string titel)
        {
            Tarify p = GetTarByTitle(titel);
            users.useusl(p);
        }
        public int GetTotalSum()
        {
            int sum = 0;
            foreach (Users c in lstUsers)
            {
                foreach (Tarify p in c.TarifesOfUser)
                {
                    sum += p.cost;
                }
            }
            return sum;
        }
        public string GetTarifesByName(string name)
        {
            Users c = GetByName(name);
            string s = $"User: {c.name}\n";
            foreach (Tarify p in c.TarifesOfUser)
            {
                s += $"{p.namet} {p.cost}\n";
            }
            return s;

        }
    }

}
