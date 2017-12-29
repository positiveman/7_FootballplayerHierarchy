using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_FootballplayerHierarchy
{
    class Footballplayer : Sportsman
    {
        public string Team { get; private set; }
        public int Number { get; private set; }

        public Footballplayer(string name, int skill, string team, int number) : base(name, skill)
        {
            Team = team;
            Number = number;
            
        }



    }
}
