using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_FootballplayerHierarchy
{
    class Sportsman
    {

        public string Name { get; private set; }

        

        public int Skill { get; protected set; }

        public Sportsman(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }

        public virtual void Train()
        {
            Skill++;
            Console.WriteLine("Skill of {0} is {1}", Name, Skill);
        }
    }
}
