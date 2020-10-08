using System;
using System.Numerics;

namespace Labb2Library
{
    public class Cuboid_3D: Shape3D
    {
        private float CubeHeight;
        private float CubeWidth;
        private float CubeDepth;

        public override float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }


        public Cuboid_3D(Vector3 center, Vector3 size)
        {
            Center = center;
            CubeHeight = size.Y;
            CubeWidth = size.X;
            CubeDepth = size.Z;
            Area = ((2.0f * CubeWidth * CubeHeight) + (2.0f * CubeWidth * CubeDepth) + (2.0f * CubeDepth * CubeHeight));
            Volume = CubeWidth * CubeDepth * CubeHeight;

        }

        public Cuboid_3D(Vector3 center, float width)
            : this(center, new Vector3(width))
        {
        }
        public Boolean IsCube()
        {
            return CubeWidth == CubeHeight && CubeHeight == CubeDepth;
        }
        public override string ToString()
        {
            String shape = "Cuboid";

            if (IsCube())
            {
                shape = "Cube";
            }

            return shape + " @(" + Center.X.ToString("n1") + ", " +
                Center.Y.ToString("n1") + ", " +
                Center.Z.ToString("n1") + ", " +
                CubeWidth.ToString("n1") + ", " +
                CubeHeight.ToString("n1") + ", l =" +
                CubeDepth.ToString("n1");
        }

    }
}
