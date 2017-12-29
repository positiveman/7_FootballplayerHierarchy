using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _7_FootballplayerHierarchy
{

    [Serializable]
    [XmlInclude(typeof(Sportsman))]
    [XmlInclude(typeof(Footballplayer))]
    [XmlInclude(typeof(Goalkeeper))]

    public class Sportsman
    {
        [XmlElement]
        public string Name { get;  set; }


        [XmlElement]
        public int Skill { get;  set; }
        public Sportsman() { }

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

        public override string ToString()
        {
            return "Sportsman " + Name + ", skill: " + Skill;
        }
    }
}
