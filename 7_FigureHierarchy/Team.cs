using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _7_FootballplayerHierarchy
{

    [XmlRoot]
    [Serializable]
    public class Team : IEnumerable<Sportsman>, IEnumerator<Sportsman>
    {
        [XmlArray]
        public List<Sportsman> DreamTeam { get; set; }
        private int index { get; set; }

        

        #region IEnumerator

        public Sportsman Current
        {
            get
            {
                return DreamTeam[index];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return DreamTeam[index];
            }
        }

        public void Dispose()
        {
            DreamTeam = null;
        }

        public bool MoveNext()
        {
            if (index == DreamTeam.Count - 1)
            {
                Reset();
                return false;
            }
            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        #endregion

        #region IEnumerable

        public IEnumerator<Sportsman> GetEnumerator()
        {
            return DreamTeam.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        #endregion

        public Team()
        {
            DreamTeam = new List<Sportsman>();
        }

        public void Add(Sportsman newSportsman)
        {
            DreamTeam.Add(newSportsman);
        }

    }
}
