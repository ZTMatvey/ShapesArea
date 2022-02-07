using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesArea
{
    public sealed class Triangle : IShape
    {
        private readonly double[] m_sides;
        private static bool IsExist(double[] sides)
        {
            var side2Check = sides[0] + sides[1] > sides[2];
            var side1Check = sides[0] + sides[2] > sides[1];
            var side0Check = sides[1] + sides[2] > sides[0];
            var isExist = side0Check && side1Check && side2Check;
            return isExist;
        }
        public double[] Sides { get
            {
                return m_sides.Clone() as double[];
            } 
        }
        public Triangle(double first, double second, double third): this(new double[] { first, second, third })
        {}
        public Triangle(double[] sides)
        {
            foreach (var side in sides)
            {
                if (side <= 0)
                    throw new ArgumentException("All sides of triangle must be greater than 0.");
            }
            if (!IsExist(sides))
                throw new ArgumentException("Triangle with the same sides cannot exist.");
            m_sides = sides.Clone() as double[];
            Array.Sort(m_sides);
        }
        public double GetArea()
        {
            var semiper = m_sides.Sum() / 2;
            var area = Math.Sqrt(semiper * 
                (semiper - m_sides[0]) * 
                (semiper - m_sides[1]) * 
                (semiper - m_sides[2]));
            return area;
        }
        public bool IsRight()
        {
            var firstLegSqr = Math.Pow(m_sides[0], 2);
            var secondLegSqr = Math.Pow(m_sides[1], 2);
            var hypotenuseSqr = Math.Pow(m_sides[2], 2);
            var isRight = hypotenuseSqr == (firstLegSqr + secondLegSqr);
            return isRight;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;
            var other = (Triangle)obj;
            var isEqual = m_sides[0] == other.m_sides[0];
            isEqual = isEqual && m_sides[1] == other.m_sides[1];
            isEqual = isEqual && m_sides[2] == other.m_sides[2];
            return isEqual;
        }
        public override int GetHashCode()
        {
            return m_sides.GetHashCode();
        }
    }
}
