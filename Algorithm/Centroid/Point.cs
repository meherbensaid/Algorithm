using System;

namespace Algorithm.Centroid
{
    public class Point : IEquatable<Point> {  
        public float X { get; set; }
        public float Y { get; set; }
        
        public Point(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Point()
        {
            
        }

        public bool Equals(Point other)
        {
            return other != null && (this.X.Equals(other.X) && this.Y.Equals(other.Y));
        }
    }
}