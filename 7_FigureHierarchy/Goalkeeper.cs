using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_FootballplayerHierarchy
{
    [Serializable]
     public class Goalkeeper : Footballplayer
    {
        public Goalkeeper() { }
        public Goalkeeper(string name, int skill, string team, int number) : base(name, skill, team, number)
        {


        }

        public override string ToString()
        {
            return "Goalkeeper " + Name +", skill: " +Skill+ ", team: "+Team+ ", Number: " + Number ;
        }

        public override void Train()
        {
            Skill += 2;
            Console.WriteLine("Skill of Goalkeeper {0} is {1}", Name, Skill);
        }

    }
}
