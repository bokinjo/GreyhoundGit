using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace Greyhound
{
    class Dogs : IEnumerable
    {
        private List<Greyhound> dogList = new List<Greyhound>();
        public int WinerCount { get; set; }

        #region Indexer and related method
        public Greyhound this[int i]
        {
            get
            {
                CheckIndex(i);
                return dogList[i];
            }
            set
            {
                CheckIndex(i);
                dogList[i] = value;
            }
        }

        private void CheckIndex(int i)
        {
            if (i < 0 || i > (Count - 1))
                throw new ArgumentOutOfRangeException();
        }

        public int Count
        {
            get
            {
                return dogList.Count;
            }
        }

        
        #endregion
        #region Methods
        public void CurentLocation()
        {
            Random random = new Random();

            foreach (Greyhound dog in dogList)
            {
                int j = random.Next(5, 15);
                dog.CurrentLocation = new Point(dog.CurrentLocation.X + j, dog.CurrentLocation.Y);
            }
        }

        public void Initial()
        {
            foreach (Greyhound dog in dogList)
            {
                dog.CurrentLocation = dog.InitialLocation;
            }
        }
        public void AddMember(Greyhound member)
        {
            dogList.Add(member);
        }

        public void SortDestination()
        {
            dogList.Sort();
        }

        public bool CheckWinner()
        {
            SortDestination();
            if (dogList[0].Destination.X < dogList[0].CurrentLocation.X)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Enumeratr
        public IEnumerator GetEnumerator()
        {
            return dogList.GetEnumerator();
        }
        #endregion


    }
}
