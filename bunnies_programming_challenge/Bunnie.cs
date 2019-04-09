using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    public class Bunnie
    {
        string name;
        string gene;
        int age;
        string color;
        bool infected;
        string sex;
        int seed;
        int cantHaveBabies;

        public Bunnie(string n,int a, string s,string g, bool inf,string col,int seed)
        {
            this.name = n;
            this.age = a;
            this.sex = s;
            this.gene = g;
            this.infected = inf;
            this.color = col;
            this.seed = seed;
            cantHaveBabies = 0;
        }

        public string Color { get => color; set => color = value; }
        public bool Infected { get => infected; set => infected = value; }
        public string Gene { get => gene; set => gene = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age1 { get => age; set => age = value; }
        public int Seed { get => seed; set => seed = value; }
        public int CantHaveBabies { get => cantHaveBabies; set => cantHaveBabies = value; }

        public void Age()
        {
            this.Age1++;
        }

        public bool isInfected()
        {
            return this.Infected;
        }

    }
}
