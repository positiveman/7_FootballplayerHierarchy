using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _7_FootballplayerHierarchy
{
    [Serializable]
    
    public class Footballplayer : Sportsman
    {
        [XmlElement]
        public string Team { get; set; }
        [XmlElement]
        public int Number { get;  set; }

        public Footballplayer() { }
        public Footballplayer(string name, int skill, string team, int number) : base(name, skill)
        {
            Team = team;
            Number = number;
            
        }

        public override string ToString()
        {
            return "Player " + Name + ", skill: " + Skill + ", team: " + Team + ", Number: " + Number;
        }
    }
}
