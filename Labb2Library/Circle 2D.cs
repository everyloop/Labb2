using System;
using System.Numerics;

namespace Labb2Library
{
    public class Circle_2D : Shape2D
    {
        private float circleRadius;

        public override float Circumference { get; }

        public override Vector3 Center { get; }
        public override float Area { get; }
        public Circle_2D(Vector2 center, float radius)
        {

            circleRadius = radius;
            Center = new Vector3(center, 0.0f);
            Circumference = (float)(2.0f * Math.PI * radius);
            Area = (float)(Math.PI * Math.Pow(radius, 2));
        }
        public override string ToString()
        {
            return "Circle @(" + Center.X.ToString("n1") + ", " +
                Center.Y.ToString("n1") + "): r = " +
                circleRadius.ToString("n1");
        }
    }
        
    
}
