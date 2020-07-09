using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Greyhound
{
    class Greyhound : IComparable<Greyhound>
    {
        public string Name { get; set; }
        public Point InitialLocation { get; set; }
        public Point CurrentLocation { get; set; }
        public Point Destination { get; set; }
        public int LabelPosition { get; set; }

        public static IComparer<Greyhound> DESComparer { get { return new DestinationComparer(); } }

        public Greyhound(string name, Point initialL, Point destination, int position)
        {
            Name = name;
            InitialLocation = initialL;
            CurrentLocation = initialL;
            Destination = destination;
            LabelPosition = position;
        }

        #region ICOMPARABLE METHOD IMPLEMENTATION
        public int CompareTo(Greyhound other)
        {
            if (CurrentLocation.X == other.CurrentLocation.X) return 0;
            else if (CurrentLocation.X > other.CurrentLocation.X) return -1;
            else return 1;
        }

        #endregion

        #region COMPARER IMPLEMENTATIONS
        private class DestinationComparer : IComparer<Greyhound>
        {
            public int Compare(Greyhound r1, Greyhound r2)
            {
                if (r1 != null && r2 != null)
                    return r1.CurrentLocation.X.CompareTo(r2.CurrentLocation.X);
                else
                    throw new ArgumentNullException("Null reference is passed instead of Greyhound object");
            }
        }
        #endregion


    }
}
