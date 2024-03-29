﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesArea
{
    public sealed class Circle : Shape
    {
        private readonly double m_radius;
        public double Radius { get => m_radius; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than 0.");
            m_radius = radius;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;
            var other = (Circle)obj;
            var isEqual = m_radius == other.m_radius;
            return isEqual;
        }
        public override int GetHashCode()=> m_radius.GetHashCode();
    }
}
