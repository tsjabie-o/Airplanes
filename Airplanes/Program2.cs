using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht_3_2
{
    class Point //: IComparable<Point>
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class XCompare : IComparer<Point>
    {
        public int Compare(Point a, Point b)
        {
            return a.X - b.X;
        }
    }

    class YCompare : IComparer<Point>
    {
        public int Compare(Point a, Point b)
        {
            return a.Y - b.Y;
        }
    }
    class Program
    {
        static void Main()
        {
            // Parse the input to get a list of airplane points, sorted for x coordinates
            Point[] airplanes = ParseInput();
            Array.Sort(airplanes, new XCompare());

            double distance = ClosestPoints(airplanes, 0, airplanes.Length - 1);
            Console.WriteLine(distance);
        }

        static Point[] ParseInput()
        {

            // The amount of airplanes in the list
            int n = Convert.ToInt32(Console.ReadLine().Split(' ')[0]);
            // List of all airplanes points
            Point[] airplanes = new Point[n];
            for (int i = 0; i < n; i++)
            {
                // Airplane point: x and y coordinate
                string[] alltext = Console.ReadLine().Split(' ');
                int x = int.Parse(alltext[0]);
                int y = int.Parse(alltext[1]);
                Point airplane = new Point(x, y);
                airplanes[i] = airplane;
            }
            return airplanes;
        }

        static double CalcDistance(Point airplane1, Point airplane2)
        {
            // Simple method for calculating distance to power of two between to points
            long x1 = airplane1.X;
            long x2 = airplane2.X;
            long y1 = airplane1.Y;
            long y2 = airplane2.Y;
            long xDist = Math.Abs(x1 - x2);
            long yDist = Math.Abs(y1 - y2);
            return Math.Pow(xDist, 2) + Math.Pow(yDist, 2);
        }

        static double ClosestPoints(Point[] airplanes, int i, int j)
        {
            // Basecase
            if (i == j)
            {
                return 9999999999999999999;
            }
            else
            {
                int mid = (i + j) / 2;

                double leftDistance;
                double rightDistance;
                double smallestDistance;

                // Divide
                leftDistance = ClosestPoints(airplanes, i, mid);
                rightDistance = ClosestPoints(airplanes, mid + 1, j);

                // Conquer

                // Find the smallest distance of left and right
                if (leftDistance <= rightDistance)
                {
                    smallestDistance = leftDistance;
                }
                else
                {
                    smallestDistance = rightDistance;
                }
                Point[] airplanesByY = new Point[j - i + 1];
                Array.Copy(airplanes, i, airplanesByY, 0, j - i + 1);
                Array.Sort(airplanesByY, new YCompare());
                // Searching for a smaller distance that crosses the middle
                int line = airplanes[mid].X;
                Point[] PointsInBand = airplanesByY.Where(point => Math.Abs(line - point.X) <= smallestDistance).ToArray();
                Point[] PointsInBandArray = PointsInBand.ToArray();
                for (int x = 0; x < PointsInBandArray.Length; x++)
                {
                    for (int z = 1; z <= 15 && z + x < PointsInBandArray.Length; z++)
                    {
                        double distance = CalcDistance(PointsInBandArray[x], PointsInBandArray[x + z]);
                        if (distance < smallestDistance)
                        {
                            smallestDistance = distance;
                        }
                    }
                }
                return smallestDistance;
            }
        }
    }
}