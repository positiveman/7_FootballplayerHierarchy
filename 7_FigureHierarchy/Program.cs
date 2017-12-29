using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _7_FootballplayerHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team { };
            team.Add(new Sportsman("Alex", 55));
            team.Add(new Footballplayer("Oleg", 90, "FCMKh", 33));
            team.Add(new Goalkeeper("Gigi Buffon", 90, "Juve", 1));

            team.DreamTeam[0].Train();
            team.DreamTeam[2].Train();

            XmlSerializer serializer = new XmlSerializer(typeof(Team));

            using (FileStream tw = new FileStream(@"C:\Users\Oleg\source\repos\7_FigureHierarchy\7_FigureHierarchy\bin\Debug\team.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(tw, team);
            }
            using (FileStream tr = new FileStream(@"C:\Users\Oleg\source\repos\7_FigureHierarchy\7_FigureHierarchy\bin\Debug\team.xml", FileMode.OpenOrCreate))
            {
                Team readedTeam = (Team)serializer.Deserialize(tr);

                foreach (var item in readedTeam)
                {
                    Console.WriteLine(item);
                }
            }

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream tw = new FileStream(@"C:\Users\Oleg\source\repos\7_FigureHierarchy\7_FigureHierarchy\bin\Debug\team.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(tw, team);
            }

            using (FileStream tr = new FileStream(@"C:\Users\Oleg\source\repos\7_FigureHierarchy\7_FigureHierarchy\bin\Debug\team.dat", FileMode.OpenOrCreate))
            {
                Team readedTeam = (Team)formatter.Deserialize(tr);

                foreach (var item in readedTeam)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
