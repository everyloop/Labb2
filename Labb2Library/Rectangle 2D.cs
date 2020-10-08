using System;
using System.Numerics;

namespace Labb2Library
{
    public class Rectangle_2D : Shape2D
    {
        private float RectWidth;
        private float RectHeight;

        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public Rectangle_2D(Vector2 center, Vector2 size)
        {
            Center = new Vector3(center, 0.0f);
            RectHeight = size.Y;
            RectWidth = size.X;
            Circumference = 2.0f * (RectWidth + RectHeight);
            Area = RectWidth * RectHeight;
        }
        public Rectangle_2D(Vector2 center, float width)
            : this(center, new Vector2(width))

        {

        }

        public Boolean IsSquare()
        {
            return RectWidth == RectHeight;
        }

        public override string ToString()
        {
            String shape = "Rectangle";

            if (IsSquare())
            {
                shape = "Square";
            }

            return shape + "@(" + Center.X.ToString("n1") + ", " +
                Center.Y.ToString("n1") + "): w = " +
                RectWidth.ToString("n1") + ", h = " +
                RectHeight.ToString("n1");
        }
    }

}