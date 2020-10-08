using System;
using System.Numerics;

namespace Labb2Library
{
    public class Sphere_3D : Shape3D
    {
        private float SphereRadius;

        public override float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public Sphere_3D(Vector3 center, float radius)
        {
            Center = center;
            SphereRadius = radius;
            Volume = (float)((4.0f / 3.0f) * Math.PI * Math.Pow(radius, 3));
            Area = (float)(4.0f * Math.PI * Math.Pow(radius, 2));
        }

        public override string ToString()
        {
            return "Sphere @ (" + Center.X + ", " + Center.Y + ", " + Center.Z + "): r = " + SphereRadius;
        }
    }
}
