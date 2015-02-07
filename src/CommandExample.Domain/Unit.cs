using System;

namespace CommandExample.Domain
{
    public sealed class Unit : IComparable
    {
        public static readonly Unit Value = new Unit();

        int IComparable.CompareTo(object obj)
        {
            return 0;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return obj == null || obj is Unit;
        }
    }
}