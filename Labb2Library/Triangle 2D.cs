using System;
using System.Collections.Generic;
using System.Collections;
using System.Numerics;
using System.Text;

namespace Labb2Library
{
    public class Triangle_2D : Shape2D, IEnumerable
    {
        private Vector2 P1;
        private Vector2 P2;
        private Vector2 P3;

        public override float Circumference { get; }

        public override float Area { get; }

        public override Vector3 Center { get; }

        public Triangle_2D(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            Center = new Vector3(
                ((P1.X + P2.X + P3.X) / 3),
                ((P1.Y + P2.Y + P3.Y) / 3), 0.0f);
            Circumference = (float)(
                Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2) +
                Math.Pow(P2.X - P3.X, 2) + Math.Pow(P2.Y - P3.Y, 2) +
                Math.Pow(P3.X - P1.X, 2) + Math.Pow(P3.Y - P1.Y, 2));
            Area = 1 / 2 * (
                (P1.X * (P2.Y - P3.Y)) +
                (P2.X * (P3.Y - P1.Y)) +
                (P3.X * (P1.Y - P2.Y)));
        }

        public override string ToString()
        {
            return "Triangle_2D @(" + Center.X.ToString("n1") + ", " + Center.Y.ToString("n1") +
                "): p1 (" + P1.X.ToString("n1") + ", " + P1.Y.ToString("n1") +
                "), p2 (" + P2.X.ToString("n1") + ", " + P2.Y.ToString("n1") +
                "), p3 (" + P3.X.ToString("n1") + ", " + P3.Y.ToString("n1") + ")";
        }

        public IEnumerator<Vector2> GetEnumerator()
        {
            return new TrianglePointEnumerator(P1, P2, P3);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class TrianglePointEnumerator : IEnumerator<Vector2>
    {
        List<Vector2> PointsList;
        private int index;

        public int Current => 0;

        object IEnumerator.Current => Current;

        Vector2 IEnumerator<Vector2>.Current => PointsList[index];

        public TrianglePointEnumerator(Vector2 P1, Vector2 P2, Vector2 P3)
        {
            index = -1;
            PointsList = new List<Vector2>();
            PointsList.Add(P1);
            PointsList.Add(P2);
            PointsList.Add(P3);
        }


        public bool MoveNext()
        {
            bool retVal = true;
            index++;

            if (index > 2)
            {
                retVal = false;
            }

            return retVal;
        }

        public void Reset()
        {
            index = -1;
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }


                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}